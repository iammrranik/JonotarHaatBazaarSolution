using JonotarHaatBazaarProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonotarHaatBazaarProject.GUI
{
    public partial class FormInvoicePrint : Form
    {
        public DbAccess DbAccess { get; set; }
        public int InvoiceId { get; set; }

        public FormInvoicePrint()
        {
            InitializeComponent();
        }

        public FormInvoicePrint(DbAccess dbAccess, int invoiceId) : this()
        {
            this.DbAccess = dbAccess;
            this.InvoiceId = invoiceId;
        }

        private void FormInvoicePrint_Load(object sender, EventArgs e)
        {
            LoadInvoiceData();
        }

        private void LoadInvoiceData()
        {
            try
            {
                string headerQuery = $@"
                    SELECT 
                        i.id,
                        i.invoiceDate,
                        i.total_amount,
                        i.discount_amount,
                        i.final_amount,
                        c.name as customer_name,
                        c.mobile as customer_mobile,
                        u.full_name as created_by
                    FROM invoice i
                    INNER JOIN customer c ON i.customerId = c.id
                    LEFT JOIN users u ON i.created_by = u.id
                    WHERE i.id = {InvoiceId}";

                DataTable headerTable = DbAccess.ExecuteQueryTable(headerQuery);

                if (headerTable != null && headerTable.Rows.Count > 0)
                {
                    DataRow row = headerTable.Rows[0];
                    
                    StringBuilder invoiceText = new StringBuilder();
                    invoiceText.AppendLine("========================================");
                    invoiceText.AppendLine("           JONOTAR HAAT BAZAAR          ");
                    invoiceText.AppendLine("========================================");
                    invoiceText.AppendLine();
                    invoiceText.AppendLine($"Invoice #: {row["id"]}");
                    invoiceText.AppendLine($"Date: {Convert.ToDateTime(row["invoiceDate"]):dd/MM/yyyy}");
                    invoiceText.AppendLine($"Time: {DateTime.Now:HH:mm:ss}");
                    invoiceText.AppendLine();
                    invoiceText.AppendLine("Customer Information:");
                    invoiceText.AppendLine($"Name: {row["customer_name"]}");
                    invoiceText.AppendLine($"Mobile: {row["customer_mobile"]}");
                    invoiceText.AppendLine();
                    invoiceText.AppendLine("========================================");
                    invoiceText.AppendLine("ITEM                    QTY  PRICE  TOTAL");
                    invoiceText.AppendLine("========================================");

                    string itemsQuery = $@"
                        SELECT 
                            p.name,
                            ii.quantity,
                            ii.unit_price,
                            ii.total_price
                        FROM invoice_items ii
                        INNER JOIN product p ON ii.product_id = p.id
                        WHERE ii.invoice_id = {InvoiceId}";

                    DataTable itemsTable = DbAccess.ExecuteQueryTable(itemsQuery);

                    if (itemsTable != null)
                    {
                        foreach (DataRow itemRow in itemsTable.Rows)
                        {
                            string itemName = itemRow["name"].ToString();
                            if (itemName.Length > 20) itemName = itemName.Substring(0, 17) + "...";
                            
                            string line = $"{itemName,-20} {itemRow["quantity"],3} {Convert.ToDecimal(itemRow["unit_price"]),6:F2} {Convert.ToDecimal(itemRow["total_price"]),6:F2}";
                            invoiceText.AppendLine(line);
                        }
                    }

                    invoiceText.AppendLine("========================================");
                    invoiceText.AppendLine($"Total Amount:                    ${Convert.ToDecimal(row["total_amount"]):F2}");
                    if (Convert.ToDecimal(row["discount_amount"]) > 0)
                    {
                        invoiceText.AppendLine($"Discount:                       -${Convert.ToDecimal(row["discount_amount"]):F2}");
                    }
                    invoiceText.AppendLine($"Final Amount:                    ${Convert.ToDecimal(row["final_amount"]):F2}");
                    invoiceText.AppendLine("========================================");
                    invoiceText.AppendLine();
                    invoiceText.AppendLine($"Served by: {row["created_by"]}");
                    invoiceText.AppendLine();
                    invoiceText.AppendLine("Thank you for shopping with us!");
                    invoiceText.AppendLine("========================================");

                    txtInvoice.Text = invoiceText.ToString();
                    
                    txtInvoice.SelectionStart = 0;
                    txtInvoice.SelectionLength = 0;
                }
                else
                {
                    MessageBox.Show("Invoice not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Printing.PrintDocument printDoc = new System.Drawing.Printing.PrintDocument();
                    printDoc.PrintPage += PrintDoc_PrintPage;
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 10);
            Brush brush = Brushes.Black;
            float y = 50;
            float lineHeight = font.GetHeight();

            string[] lines = txtInvoice.Text.Split('\n');
            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, font, brush, 50, y);
                y += lineHeight;
                
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
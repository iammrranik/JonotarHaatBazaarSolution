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
    public partial class FormSalesReport : Form
    {
        public DbAccess DbAccess { get; set; }
        public new Form ParentForm { get; set; }

        public FormSalesReport()
        {
            InitializeComponent();
        }

        public FormSalesReport(DbAccess dbAccess) : this()
        {
            this.DbAccess = dbAccess;
        }

        public FormSalesReport(DbAccess dbAccess, Form parentForm) : this()
        {
            this.DbAccess = dbAccess;
            this.ParentForm = parentForm;
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;
            
            LoadSalesReport();
            dgvInvoiceDetails.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void LoadSalesReport()
        {
            try
            {
                string fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                string toDate = dtpToDate.Value.ToString("yyyy-MM-dd");

                string summaryQuery = $@"
                    SELECT 
                        i.id as 'Invoice ID',
                        c.name as 'Customer Name',
                        c.mobile as 'Mobile',
                        i.invoiceDate as 'Invoice Date',
                        i.total_amount as 'Total Amount',
                        i.discount_amount as 'Discount',
                        i.final_amount as 'Final Amount',
                        u.full_name as 'Created By'
                    FROM invoice i
                    INNER JOIN customer c ON i.customerId = c.id
                    LEFT JOIN users u ON i.created_by = u.id
                    WHERE i.invoiceDate BETWEEN '{fromDate}' AND '{toDate}'
                    ORDER BY i.invoiceDate DESC, i.id DESC";

                DataTable invoicesTable = DbAccess.ExecuteQueryTable(summaryQuery);
                
                if (invoicesTable != null)
                {
                    dgvInvoices.DataSource = invoicesTable;
                    
                    if (dgvInvoices.Columns["Total Amount"] != null)
                    {
                        dgvInvoices.Columns["Total Amount"].DefaultCellStyle.Format = "C2";
                        dgvInvoices.Columns["Total Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (dgvInvoices.Columns["Discount"] != null)
                    {
                        dgvInvoices.Columns["Discount"].DefaultCellStyle.Format = "C2";
                        dgvInvoices.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (dgvInvoices.Columns["Final Amount"] != null)
                    {
                        dgvInvoices.Columns["Final Amount"].DefaultCellStyle.Format = "C2";
                        dgvInvoices.Columns["Final Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (dgvInvoices.Columns["Invoice Date"] != null)
                    {
                        dgvInvoices.Columns["Invoice Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                    
                    dgvInvoices.ClearSelection();
                }

                LoadSummaryStatistics(fromDate, toDate);
                
                dgvInvoiceDetails.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSummaryStatistics(string fromDate, string toDate)
        {
            try
            {
                string statsQuery = $@"
                    SELECT 
                        COUNT(*) as TotalInvoices,
                        ISNULL(SUM(total_amount), 0) as TotalSales,
                        ISNULL(SUM(discount_amount), 0) as TotalDiscount,
                        ISNULL(SUM(final_amount), 0) as NetSales,
                        ISNULL(AVG(final_amount), 0) as AverageSale
                    FROM invoice 
                    WHERE invoiceDate BETWEEN '{fromDate}' AND '{toDate}'";

                DataTable statsTable = DbAccess.ExecuteQueryTable(statsQuery);
                
                if (statsTable != null && statsTable.Rows.Count > 0)
                {
                    DataRow row = statsTable.Rows[0];
                    
                    lblTotalInvoices.Text = $"Total Invoices: \n{row["TotalInvoices"]}";
                    lblTotalSales.Text = $"Total Sales: \n${Convert.ToDecimal(row["TotalSales"]):F2}";
                    lblTotalDiscount.Text = $"Total Discount: \n${Convert.ToDecimal(row["TotalDiscount"]):F2}";
                    lblNetSales.Text = $"Net Sales: \n${Convert.ToDecimal(row["NetSales"]):F2}";
                    lblAverageSale.Text = $"Average Sale: \n${Convert.ToDecimal(row["AverageSale"]):F2}";
                }
                else
                {
                    lblTotalInvoices.Text = "Total Invoices: \n0";
                    lblTotalSales.Text = "Total Sales: \n$0.00";
                    lblTotalDiscount.Text = "Total Discount: \n$0.00";
                    lblNetSales.Text = "Net Sales: \n$0.00";
                    lblAverageSale.Text = "Average Sale: \n$0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading summary statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                try
                {
                    int invoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["Invoice ID"].Value);
                    LoadInvoiceDetails(invoiceId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading invoice details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadInvoiceDetails(int invoiceId)
        {
            try
            {
                string detailsQuery = $@"
                    SELECT 
                        p.name as 'Product Name',
                        ii.unit_price as 'Unit Price',
                        ii.quantity as 'Quantity',
                        ii.total_price as 'Total Price'
                    FROM invoice_items ii
                    INNER JOIN product p ON ii.product_id = p.id
                    WHERE ii.invoice_id = {invoiceId}";

                DataTable detailsTable = DbAccess.ExecuteQueryTable(detailsQuery);
                
                if (detailsTable != null)
                {
                    dgvInvoiceDetails.DataSource = detailsTable;
                    
                    if (dgvInvoiceDetails.Columns["Unit Price"] != null)
                    {
                        dgvInvoiceDetails.Columns["Unit Price"].DefaultCellStyle.Format = "C2";
                        dgvInvoiceDetails.Columns["Unit Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (dgvInvoiceDetails.Columns["Total Price"] != null)
                    {
                        dgvInvoiceDetails.Columns["Total Price"].DefaultCellStyle.Format = "C2";
                        dgvInvoiceDetails.Columns["Total Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    
                    dgvInvoiceDetails.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                try
                {
                    int invoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["Invoice ID"].Value);
                    FormInvoicePrint printForm = new FormInvoicePrint(DbAccess, invoiceId);
                    printForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening print preview: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an invoice to print.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                try
                {
                    int invoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["Invoice ID"].Value);
                    string customerName = dgvInvoices.SelectedRows[0].Cells["Customer Name"].Value.ToString();
                    string invoiceDate = Convert.ToDateTime(dgvInvoices.SelectedRows[0].Cells["Invoice Date"].Value).ToString("dd/MM/yyyy");
                    decimal finalAmount = Convert.ToDecimal(dgvInvoices.SelectedRows[0].Cells["Final Amount"].Value);
                    
                    var confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete this invoice?\n\n" +
                        $"Invoice ID: {invoiceId}\n" +
                        $"Customer: {customerName}\n" +
                        $"Date: {invoiceDate}\n" +
                        $"Amount: ${finalAmount:F2}\n\n" +
                        $"This action cannot be undone and will restore product quantities to inventory.",
                        "Confirm Delete Invoice",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2
                    );
                    
                    if (confirmResult == DialogResult.Yes)
                    {
                        DeleteInvoice(invoiceId);
                        MessageBox.Show("Invoice deleted successfully and product quantities have been restored.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSalesReport(); 
                        dgvInvoiceDetails.DataSource = null; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an invoice to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteInvoice(int invoiceId)
        {
            try
            {
                string restoreQuery = $@"
                    UPDATE p 
                    SET quantity = p.quantity + ii.quantity
                    FROM product p
                    INNER JOIN invoice_items ii ON p.id = ii.product_id
                    WHERE ii.invoice_id = {invoiceId}";
                DbAccess.ExecuteDMLQuery(restoreQuery);

                string deleteItemsSql = $"DELETE FROM invoice_items WHERE invoice_id = {invoiceId}";
                DbAccess.ExecuteDMLQuery(deleteItemsSql);

                string deleteInvoiceSql = $"DELETE FROM invoice WHERE id = {invoiceId}";
                DbAccess.ExecuteDMLQuery(deleteInvoiceSql);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete invoice: " + ex.Message);
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";
                saveFileDialog.FileName = $"SalesReport_{dtpFromDate.Value:yyyyMMdd}_to_{dtpToDate.Value:yyyyMMdd}";
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodaysSales_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today;
            LoadSalesReport();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;
            LoadSalesReport();
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpToDate.Value = DateTime.Now;
            LoadSalesReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvInvoices_DoubleClick(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                try
                {
                    int invoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["Invoice ID"].Value);
                    
                    FormAddSale editSaleForm = new FormAddSale(DbAccess, invoiceId, true, this); 
                    editSaleForm.ShowDialog();
                    
                    LoadSalesReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening invoice for editing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Show();
            }
            base.OnFormClosed(e);
        }
    }
} 
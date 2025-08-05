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
    public partial class FormAddSale : Form
    {
        public DbAccess DbAccess { get; set; }
        public int UserId { get; set; }
        public new Form ParentForm { get; set; }
        private DataTable productsTable;
        private DataTable invoiceItemsTable;
        private decimal totalAmount = 0;
        private decimal discountAmount = 0;
        private decimal finalAmount = 0;
        private int EditInvoiceId = -1;
        private bool IsEditMode = false;

        public FormAddSale()
        {
            InitializeComponent();
        }

        public FormAddSale(DbAccess dbAccess, int userId) : this()
        {
            this.DbAccess = dbAccess;
            this.UserId = userId;
        }

        public FormAddSale(DbAccess dbAccess, int userId, Form parentForm) : this()
        {
            this.DbAccess = dbAccess;
            this.UserId = userId;
            this.ParentForm = parentForm;
        }

        public FormAddSale(DbAccess dbAccess, int invoiceId, bool editMode) : this()
        {
            this.DbAccess = dbAccess;
            this.EditInvoiceId = invoiceId;
            this.IsEditMode = editMode;
        }

        public FormAddSale(DbAccess dbAccess, int invoiceId, bool editMode, Form parentForm) : this()
        {
            this.DbAccess = dbAccess;
            this.EditInvoiceId = invoiceId;
            this.IsEditMode = editMode;
            this.ParentForm = parentForm;
        }

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCustomers();
            InitializeInvoiceItemsTable();
            
            if (IsEditMode && EditInvoiceId > 0)
            {
                LoadInvoiceForEdit(EditInvoiceId);
                this.Text = $"Edit Invoice #{EditInvoiceId}";
            }
            else
            {
                dtpInvoiceDate.Value = DateTime.Now;
                txtDiscount.Text = "0";
                this.Text = "Add New Sale";
            }
            
            UpdateTotals();
        }

        private void LoadProducts()
        {
            try
            {
                string sql = "SELECT id, name, unit_price, quantity FROM product WHERE is_active = 1 AND quantity > 0";
                productsTable = DbAccess.ExecuteQueryTable(sql);
                
                if (productsTable != null)
                {
                    cmbProduct.SelectedIndexChanged -= cmbProduct_SelectedIndexChanged;
                    
                    cmbProduct.DataSource = productsTable;
                    cmbProduct.DisplayMember = "name";
                    cmbProduct.ValueMember = "id";
                    cmbProduct.SelectedIndex = -1;
                    
                    cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
                    
                    ClearProductDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                string sql = "SELECT id, name, mobile FROM customer";
                DataTable customersTable = DbAccess.ExecuteQueryTable(sql);
                
                if (customersTable != null)
                {
                    DataColumn displayColumn = new DataColumn("DisplayInfo", typeof(string));
                    displayColumn.Expression = "mobile + ' (' + name + ')'";
                    customersTable.Columns.Add(displayColumn);

                    cmbCustomer.DataSource = customersTable;
                    cmbCustomer.DisplayMember = "DisplayInfo";
                    //cmbCustomer.DisplayMember = "mobile";
                    cmbCustomer.ValueMember = "id";
                    cmbCustomer.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeInvoiceItemsTable()
        {
            invoiceItemsTable = new DataTable();
            invoiceItemsTable.Columns.Add("ProductId", typeof(int));
            invoiceItemsTable.Columns.Add("ProductName", typeof(string));
            invoiceItemsTable.Columns.Add("UnitPrice", typeof(decimal));
            invoiceItemsTable.Columns.Add("Quantity", typeof(int));
            invoiceItemsTable.Columns.Add("TotalPrice", typeof(decimal));
            
            dgvInvoiceItems.DataSource = invoiceItemsTable;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cmbProduct.SelectedItem;
                txtUnitPrice.Text = selectedRow["unit_price"].ToString();
                lblAvailableStock.Text = "Available: " + selectedRow["quantity"].ToString();
                //nudQuantity.Maximum = Convert.ToDecimal(selectedRow["quantity"]);
                //nudQuantity.Value = 1;
                nudQuantity.Text = "1";
            }
            else
            {
                ClearProductDetails();
            }
        }

        private void ClearProductDetails()
        {
            txtUnitPrice.Text = "";
            lblAvailableStock.Text = "";
            nudQuantity.Text = "1";
            txtItemTotal.Text = "";
        }


        private void nudQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateItemTotal();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateItemTotal();
        }

        private void UpdateItemTotal()
        {
            if(nudQuantity.Text == "")
            {
                nudQuantity.Text = "0";
            }
            if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                decimal total = unitPrice * Convert.ToInt32(nudQuantity.Text);
                txtItemTotal.Text = total.ToString("F2");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(nudQuantity.Text) <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRowView selectedProduct = (DataRowView)cmbProduct.SelectedItem;
                int productId = Convert.ToInt32(selectedProduct["id"]);
                string productName = selectedProduct["name"].ToString();
                decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                int quantity = Convert.ToInt32(Convert.ToInt32(nudQuantity.Text));
                decimal totalPrice = unitPrice * quantity;

                DataRow[] existingRows = invoiceItemsTable.Select($"ProductId = {productId}");
                if (existingRows.Length > 0)
                {
                    DataRow existingRow = existingRows[0];
                    int existingQty = Convert.ToInt32(existingRow["Quantity"]);
                    int newQty = existingQty + quantity;
                    
                    int availableStock = Convert.ToInt32(selectedProduct["quantity"]);
                    if (newQty > availableStock)
                    {
                        MessageBox.Show($"Insufficient stock. Available: {availableStock}, Requested: {newQty}", 
                            "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    existingRow["Quantity"] = newQty;
                    existingRow["TotalPrice"] = unitPrice * newQty;
                }
                else
                {
                    DataRow newRow = invoiceItemsTable.NewRow();
                    newRow["ProductId"] = productId;
                    newRow["ProductName"] = productName;
                    newRow["UnitPrice"] = unitPrice;
                    newRow["Quantity"] = quantity;
                    newRow["TotalPrice"] = totalPrice;
                    invoiceItemsTable.Rows.Add(newRow);
                }

                UpdateTotals();
                ClearItemInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoiceItems.SelectedRows.Count > 0)
                {
                    dgvInvoiceItems.Rows.RemoveAt(dgvInvoiceItems.SelectedRows[0].Index);
                    UpdateTotals();
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            totalAmount = 0;
            foreach (DataRow row in invoiceItemsTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["TotalPrice"]);
            }

            if (decimal.TryParse(txtDiscount.Text, out discountAmount))
            {
                finalAmount = totalAmount - discountAmount;
                if (finalAmount < 0) finalAmount = 0;
            }
            else
            {
                discountAmount = 0;
                finalAmount = totalAmount;
            }

            lblTotalAmount.Text = $"Total: ${totalAmount:F2}";
            lblFinalAmount.Text = $"Final: ${finalAmount:F2}";
        }

        private void ClearItemInputs()
        {
            cmbProduct.SelectedIndex = -1;
            ClearProductDetails();
        }

        private void LoadInvoiceForEdit(int invoiceId)
        {
            try
            {
                string invoiceQuery = $@"
                    SELECT i.customerId, i.invoiceDate, i.discount_amount, i.created_by, c.name as customer_name
                    FROM invoice i
                    INNER JOIN customer c ON i.customerId = c.id
                    WHERE i.id = {invoiceId}";

                DataTable invoiceTable = DbAccess.ExecuteQueryTable(invoiceQuery);
                
                if (invoiceTable != null && invoiceTable.Rows.Count > 0)
                {
                    DataRow invoiceRow = invoiceTable.Rows[0];
                    
                    cmbCustomer.SelectedValue = Convert.ToInt32(invoiceRow["customerId"]);
                    
                    dtpInvoiceDate.Value = Convert.ToDateTime(invoiceRow["invoiceDate"]);
                    
                    txtDiscount.Text = invoiceRow["discount_amount"].ToString();
                    
                    this.UserId = Convert.ToInt32(invoiceRow["created_by"]);
                }

                string itemsQuery = $@"
                    SELECT ii.product_id, p.name as product_name, ii.unit_price, ii.quantity,
                           (ii.unit_price * ii.quantity) as total_price
                    FROM invoice_items ii
                    INNER JOIN product p ON ii.product_id = p.id
                    WHERE ii.invoice_id = {invoiceId}";

                DataTable itemsTable = DbAccess.ExecuteQueryTable(itemsQuery);
                
                if (itemsTable != null)
                {
                    foreach (DataRow row in itemsTable.Rows)
                    {
                        DataRow newRow = invoiceItemsTable.NewRow();
                        newRow["ProductId"] = row["product_id"];
                        newRow["ProductName"] = row["product_name"];
                        newRow["UnitPrice"] = row["unit_price"];
                        newRow["Quantity"] = row["quantity"];
                        newRow["TotalPrice"] = row["total_price"];
                        invoiceItemsTable.Rows.Add(newRow);
                    }
                }
                
                UpdateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice for edit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddCustomer formAddCustomer = new FormAddCustomer(DbAccess);
                formAddCustomer.CustomerAdded += FormAddCustomer_CustomerAdded;
                formAddCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening add customer form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddCustomer_CustomerAdded(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (invoiceItemsTable.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to the invoice.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                int invoiceId;

                if (IsEditMode && EditInvoiceId > 0)
                {
                    invoiceId = EditInvoiceId;
                    
                    string restoreQuery = $@"
                        UPDATE p 
                        SET quantity = p.quantity + ii.quantity
                        FROM product p
                        INNER JOIN invoice_items ii ON p.id = ii.product_id
                        WHERE ii.invoice_id = {invoiceId}";
                    DbAccess.ExecuteDMLQuery(restoreQuery);

                    string deleteItemsSql = $"DELETE FROM invoice_items WHERE invoice_id = {invoiceId}";
                    DbAccess.ExecuteDMLQuery(deleteItemsSql);

                    string updateInvoiceSql = $@"
                        UPDATE invoice 
                        SET customerId = {customerId}, 
                            invoiceDate = '{dtpInvoiceDate.Value:yyyy-MM-dd}', 
                            total_amount = {totalAmount}, 
                            discount_amount = {discountAmount}, 
                            final_amount = {finalAmount}
                        WHERE id = {invoiceId}";
                    DbAccess.ExecuteDMLQuery(updateInvoiceSql);
                }
                else
                {
                    string invoiceSql = $@"
                        INSERT INTO invoice (customerId, invoiceDate, total_amount, discount_amount, final_amount, created_by, created_date)
                        VALUES ({customerId}, '{dtpInvoiceDate.Value:yyyy-MM-dd}', {totalAmount}, {discountAmount}, {finalAmount}, {UserId}, GETDATE());
                        SELECT SCOPE_IDENTITY();";
                    
                    DataTable invoiceResult = DbAccess.ExecuteQueryTable(invoiceSql);
                    invoiceId = Convert.ToInt32(invoiceResult.Rows[0][0]);
                }

                foreach (DataRow row in invoiceItemsTable.Rows)
                {
                    int productId = Convert.ToInt32(row["ProductId"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);

                    string itemSql = $@"
                        INSERT INTO invoice_items (invoice_id, product_id, quantity, unit_price)
                        VALUES ({invoiceId}, {productId}, {quantity}, {unitPrice})";
                    DbAccess.ExecuteDMLQuery(itemSql);

                    string updateProductSql = $@"
                        UPDATE product 
                        SET quantity = quantity - {quantity}
                        WHERE id = {productId}";
                    DbAccess.ExecuteDMLQuery(updateProductSql);
                }

                string action = IsEditMode ? "updated" : "saved";
                MessageBox.Show($"Invoice #{invoiceId} {action} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                var printResult = MessageBox.Show("Do you want to print the invoice?", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (printResult == DialogResult.Yes)
                {
                    PrintInvoice(invoiceId);
                }

                if (!IsEditMode)
                {
                    ClearForm();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintInvoice(int invoiceId)
        {
            try
            {
                FormInvoicePrint printForm = new FormInvoicePrint(DbAccess, invoiceId);
                printForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening print preview: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            cmbCustomer.SelectedIndex = -1;
            invoiceItemsTable.Clear();
            ClearItemInputs();
            txtDiscount.Text = "0";
            dtpInvoiceDate.Value = DateTime.Now;
            UpdateTotals();
            LoadProducts(); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all data?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Show();
            }
            base.OnFormClosed(e);
        }

        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
} 
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
    public partial class FormAddProduct : Form
    {
        public DbAccess DbAccess { get; set; }
        public UserControlProduct UserControlProduct { get; set; }
        public int SelectionRow { get; set; }
        private bool IsEditMode { get; set; }

        public FormAddProduct()
        {
            InitializeComponent();
        }

        public FormAddProduct(DbAccess dbAccess, UserControlProduct userControlProduct, int selectedRow) : this()
        {
            this.DbAccess = dbAccess;
            this.UserControlProduct = userControlProduct;
            this.SelectionRow = selectedRow;
            this.IsEditMode = selectedRow != -1;
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            chkIsActive.Checked = true;
            dtpCreatedDate.Value = DateTime.Now;
            dtpCreatedDate.Enabled = false;

            ClearErrorHighlighting();
            ClearErrorMessages();

            if (IsEditMode)
            {
                lblTitle.Text = "Update Product";
                btnSave.Text = "Update Product";
                LoadProductData();
            }
            else
            {
                lblTitle.Text = "Add New Product";
                btnSave.Text = "Save Product";
                LoadNextProductId();
            }
        }

        private void LoadNextProductId()
        {
            if (this.DbAccess == null)
            {
                MessageBox.Show("Database access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "SELECT ISNULL(MAX(id), 0) + 1 FROM product;";
                var ds = this.DbAccess.ExecuteQuery(sql);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    var nextId = ds.Tables[0].Rows[0][0].ToString();
                    this.txtId.Text = nextId;
                    this.txtId.Enabled = false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next product ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductData()
        {
            if (this.DbAccess == null)
            {
                MessageBox.Show("Database access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "SELECT * FROM product WHERE id = @id;";
                string sqlWithParam = sql.Replace("@id", this.SelectionRow.ToString());
                var ds = this.DbAccess.ExecuteQuery(sqlWithParam);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    var row = ds.Tables[0].Rows[0];
                    
                    this.txtId.Text = row["id"].ToString();
                    this.txtId.Enabled = false; 
                    this.txtName.Text = row["name"].ToString();
                    this.txtQuantity.Text = row["quantity"].ToString();
                    
                    if (DateTime.TryParse(row["manufactureDate"].ToString(), out DateTime mfgDate))
                        this.dtpManufactureDate.Value = mfgDate;
                    
                    if (DateTime.TryParse(row["expiryDate"].ToString(), out DateTime expDate))
                        this.dtpExpiaryDate.Value = expDate;
                    
                    this.txtCategoryName.Text = row["categoryName"].ToString();
                    this.txtUnitPrice.Text = row["unit_price"].ToString();
                    
                    if (DateTime.TryParse(row["created_date"].ToString(), out DateTime createdDate))
                        this.dtpCreatedDate.Value = createdDate;
                    
                    this.chkIsActive.Checked = Convert.ToBoolean(row["is_active"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (IsEditMode)
                    UpdateProduct();
                else
                    SaveProduct();
            }
        }

        private bool ValidateFields()
        {
            ClearErrorHighlighting();
            ClearErrorMessages();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowError(txtName, lblNameError, "Product Name is required");
                isValid = false;
            }
            else if (txtName.Text.Length < 2 || txtName.Text.Length > 50)
            {
                ShowError(txtName, lblNameError, "Product Name must be between 2 and 50 characters");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                ShowError(txtQuantity, lblQuantityError, "Quantity is required");
                isValid = false;
            }
            else if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                ShowError(txtQuantity, lblQuantityError, "Quantity must be a non-negative whole number");
                isValid = false;
            }

            if (dtpManufactureDate.Value.Date > DateTime.Today)
            {
                ShowError(dtpManufactureDate, lblManufactureError, "Manufacture Date cannot be in the future");
                isValid = false;
            }

            if (dtpExpiaryDate.Value <= dtpManufactureDate.Value)
            {
                ShowError(dtpExpiaryDate, lblExpiaryError, "Expiry Date must be after Manufacture Date");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                ShowError(txtCategoryName, lblCategoryError, "Category Name is required");
                isValid = false;
            }
            else if (txtCategoryName.Text.Length < 2 || txtCategoryName.Text.Length > 50)
            {
                ShowError(txtCategoryName, lblCategoryError, "Category Name must be between 2 and 50 characters");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                ShowError(txtUnitPrice, lblUnitPriceError, "Unit Price is required");
                isValid = false;
            }
            else if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                ShowError(txtUnitPrice, lblUnitPriceError, "Unit Price must be a positive number");
                isValid = false;
            }

            return isValid;
        }

        private void SaveProduct()
        {
            try
            {
                string name = txtName.Text.Replace("'", "''");
                int quantity = int.Parse(txtQuantity.Text);
                DateTime manufactureDate = dtpManufactureDate.Value;
                DateTime expiryDate = dtpExpiaryDate.Value;
                string categoryName = txtCategoryName.Text.Replace("'", "''");
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                DateTime createdDate = dtpCreatedDate.Value;
                bool isActive = chkIsActive.Checked;

                string sql = $@"INSERT INTO product 
                                (name, quantity, manufactureDate, expiryDate, categoryName, unit_price, created_date, is_active)
                                VALUES('{name}', {quantity}, '{manufactureDate.ToString("yyyy-MM-dd")}', '{expiryDate.ToString("yyyy-MM-dd")}', 
                                 '{categoryName}', {unitPrice}, '{createdDate.ToString("yyyy-MM-dd")}', {(isActive ? 1 : 0)})";

                int result = DbAccess.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserControlProduct.PopulateGridView();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure Quantity and Unit Price are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct()
        {
            try
            {
                string name = txtName.Text.Replace("'", "''");
                int quantity = int.Parse(txtQuantity.Text);
                DateTime manufactureDate = dtpManufactureDate.Value;
                DateTime expiryDate = dtpExpiaryDate.Value;
                string categoryName = txtCategoryName.Text.Replace("'", "''");
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                bool isActive = chkIsActive.Checked;
                int productId = int.Parse(txtId.Text);

                string sql = $@"UPDATE product SET 
                                name = '{name}',
                                quantity = {quantity},
                                manufactureDate = '{manufactureDate.ToString("yyyy-MM-dd")}',
                                expiryDate = '{expiryDate.ToString("yyyy-MM-dd")}',
                                categoryName = '{categoryName}',
                                unit_price = {unitPrice},
                                is_active = {(isActive ? 1 : 0)}
                                WHERE id = {productId}";

                int result = DbAccess.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserControlProduct.PopulateGridView();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure Quantity and Unit Price are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowError(Control control, Label errorLabel, string message)
        {
            control.BackColor = Color.LightPink;
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void ClearErrorHighlighting()
        {
            txtName.BackColor = Color.White;
            txtQuantity.BackColor = Color.White;
            dtpManufactureDate.BackColor = Color.White;
            dtpExpiaryDate.BackColor = Color.White;
            txtCategoryName.BackColor = Color.White;
            txtUnitPrice.BackColor = Color.White;
            dtpCreatedDate.BackColor = Color.White;
        }

        private void ClearErrorMessages()
        {
            lblNameError.Text = "";
            lblNameError.Visible = false;
            lblQuantityError.Text = "";
            lblQuantityError.Visible = false;
            lblManufactureError.Text = "";
            lblManufactureError.Visible = false;
            lblExpiaryError.Text = "";
            lblExpiaryError.Visible = false;
            lblCategoryError.Text = "";
            lblCategoryError.Visible = false;
            lblUnitPriceError.Text = "";
            lblUnitPriceError.Visible = false;
            lblCreatedError.Text = "";
            lblCreatedError.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

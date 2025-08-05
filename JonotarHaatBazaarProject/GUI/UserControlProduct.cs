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
    public partial class UserControlProduct : UserControl
    {
        public DbAccess DbAccess { get; set; }
        public UserControlProduct()
        {
            InitializeComponent();
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.dgvProduct.ClearSelection();
        }

        public UserControlProduct(DbAccess dbAccess) : this()
        {
            this.DbAccess = dbAccess;
        }

        internal void PopulateGridView()
        {
            if (this.DbAccess == null)
            {
                MessageBox.Show("Database access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "select * from product;";
                var ds = this.DbAccess.ExecuteQuery(sql);
                this.dgvProduct.AutoGenerateColumns = false;

                if (ds != null && ds.Tables.Count > 0)
                {
                    this.dgvProduct.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvProduct.DataSource = null;
                }
                
                this.dgvProduct.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating grid: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.txtSearchName.Text = "";
            this.PopulateGridView();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    FormAddProduct formAddProduct = new FormAddProduct(DbAccess, this, -1);
                    formAddProduct.Show();
                }
                else if(this.dgvProduct.SelectedRows.Count == 1)
                {
                    //FormAddProduct formAddProduct = new FormAddProduct(DbAccess, this, this.dgvProduct.CurrentRow.Cells["id"].Value);
                    FormAddProduct formAddProduct = new FormAddProduct(DbAccess, this, Convert.ToInt32(this.dgvProduct.CurrentRow.Cells["id"].Value));
                    formAddProduct.Show();
                }
                else
                {
                    MessageBox.Show("Please select one row.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again to add row." + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            {
                PopulateGridView();
                return;
            }

            if (this.DbAccess == null)
            {
                MessageBox.Show("Database access not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string searchName = txtSearchName.Text.Replace("'", "''");
                string sql = $"SELECT * FROM product WHERE name LIKE '%{searchName}%'";
                var ds = this.DbAccess.ExecuteQuery(sql);
                this.dgvProduct.AutoGenerateColumns = false;

                if (ds != null && ds.Tables.Count > 0)
                {
                    this.dgvProduct.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvProduct.DataSource = null;
                    MessageBox.Show("No products found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                this.dgvProduct.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var productId = this.dgvProduct.CurrentRow.Cells["Id"].Value.ToString();
                var productName = this.dgvProduct.CurrentRow.Cells["name"].Value.ToString();

                var result = MessageBox.Show($"Are you sure you want to delete product '{productName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                string sql = "DELETE FROM product WHERE Id = '" + productId.Replace("'", "''") + "';";
                var count = this.DbAccess.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(productName.ToUpper() + " has been removed from the list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete product. Data hasn't been deleted from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to delete the row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

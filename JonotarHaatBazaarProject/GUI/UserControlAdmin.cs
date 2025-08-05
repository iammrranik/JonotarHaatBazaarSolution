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
    public partial class UserControlAdmin : UserControl
    {
        public DbAccess DbAccess { get; set; }
        public UserControlAdmin()
        {
            InitializeComponent();
        }

        public UserControlAdmin(DbAccess dbAccess) : this()
        {
            this.DbAccess = dbAccess;
            this.PopulateGridView();
            //this.LoadAllUsers();
        }

        private void LoadAllUsers()
        {
            PopulateGridView("SELECT u.id, u.full_name, u.email, u.username, r.role_name as role_name, u.mobile, u.nid, u.address, u.created_date, u.is_active FROM users u LEFT JOIN role r ON u.role_id = r.id ORDER BY u.id");
        }

        internal void PopulateGridView(string sql = "SELECT u.id, u.full_name, u.email, u.username, r.role_name as role_name, u.mobile, u.nid, u.address, u.created_date, u.is_active FROM users u LEFT JOIN role r ON u.role_id = r.id ORDER BY u.id")
        {
            if (this.DbAccess == null)
            {
                MessageBox.Show("Database access object is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var ds = this.DbAccess.ExecuteQuery(sql);
                
                if (ds != null)
                {
                    this.dgvAdmin.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvAdmin.DataSource = null;
                }
                this.dgvAdmin.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error populating grid: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim();
            
            if (string.IsNullOrEmpty(searchName))
            {
                LoadAllUsers();
            }
            else
            {
                string sql = "SELECT u.id, u.full_name, u.email, u.username, r.role_name as role_name, u.mobile, u.nid, u.address, u.created_date, u.is_active FROM users u LEFT JOIN role r ON u.role_id = r.id WHERE u.full_name LIKE '%" + searchName.Replace("'", "''") + "%' ORDER BY u.id";
                PopulateGridView(sql);
            }
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
            LoadAllUsers();
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAdmin.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                try
                {
                    int userId = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells["id"].Value);
                    
                    FormEditUser editUserForm = new FormEditUser(this.DbAccess, this, userId);
                    DialogResult result = editUserForm.ShowDialog();
                    
                    if (result == DialogResult.OK)
                    {
                        LoadAllUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening Edit User form: " + ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddUser addUserForm = new FormAddUser(this.DbAccess, this);
                DialogResult result = addUserForm.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    LoadAllUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Add User form: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshUserData()
        {
            LoadAllUsers();
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            if (this.DbAccess != null)
            {
                LoadAllUsers();
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAdmin.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                    
                    
                var id = this.dgvAdmin.CurrentRow.Cells["Id"].Value.ToString();
                var fullName = this.dgvAdmin.CurrentRow.Cells["full_name"].Value.ToString();

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from users where Id = '" + id + "';";
                var count = this.DbAccess.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(fullName.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.LoadAllUsers();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Deleting user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            this.dgvAdmin.ClearSelection();
            this.txtSearchName.Clear();
            this.LoadAllUsers();
        }
    }
}

using JonotarHaatBazaarProject.DB;
using JonotarHaatBazaarProject.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonotarHaatBazaarProject
{
    public partial class FormLogin : Form
    {
        public DbAccess DbAccess { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            try
            {
                this.DbAccess = new DbAccess();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in opening the database system, please try again.\n" + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                string sql = @"SELECT u.id, u.username, u.password, u.full_name, r.role_name, u.is_active 
                              FROM users u 
                              INNER JOIN role r ON u.role_id = r.id 
                              WHERE u.username = '" + username.Replace("'", "''") + "' " +
                              "AND u.password = '" + password.Replace("'", "''") + "' " +
                              "AND r.role_name IN ('Admin', 'Employee') " +
                              "AND u.is_active = 1";

                var dataTable = DbAccess.ExecuteQueryTable(sql);
                
                if (dataTable != null && dataTable.Rows.Count == 1)
                {
                    var row = dataTable.Rows[0];
                    string roleName = row["role_name"].ToString();
                    string fullName = row["full_name"].ToString();
                    
                    if (roleName.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Welcome {fullName}!\nLogin successful as Administrator.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormAdmin formAdmin = new FormAdmin(DbAccess, this, username);
                        formAdmin.Show();
                        this.Hide();
                    }
                    else if (roleName.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Welcome {fullName}!\nLogin successful as Employee.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormEmployee formEmployee = new FormEmployee(DbAccess, this, username);
                        formEmployee.Show();
                        this.Hide();
                    }
                }
                else
                {
                    string checkUserSql = @"SELECT u.username, u.is_active, r.role_name 
                                           FROM users u 
                                           INNER JOIN role r ON u.role_id = r.id 
                                           WHERE u.username = '" + username.Replace("'", "''") + "'";
                    
                    var checkTable = DbAccess.ExecuteQueryTable(checkUserSql);
                    
                    if (checkTable != null && checkTable.Rows.Count > 0)
                    {
                        bool isActive = Convert.ToBoolean(checkTable.Rows[0]["is_active"]);
                        string userRole = checkTable.Rows[0]["role_name"].ToString();
                        
                        if (!isActive)
                        {
                            MessageBox.Show("Your account is currently inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Close();
                this.DbAccess.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in closing system.\n" + ex.Message);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in closing database system.\n" + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

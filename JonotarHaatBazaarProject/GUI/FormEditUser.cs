using JonotarHaatBazaarProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonotarHaatBazaarProject.GUI
{
    public partial class FormEditUser : Form
    {
        public DbAccess DbAccess { get; set; }
        public UserControlAdmin UserAdmin { get; set; }
        private int UserId { get; set; }


        public class ComboBoxItemEdit
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(DbAccess dbAccess, UserControlAdmin userAdmin, int userId) : this()
        {
            this.DbAccess = dbAccess;
            this.UserAdmin = userAdmin;
            this.UserId = userId;
            LoadRoles();
            LoadUserData();
        }

        private void LoadRoles()
        {
            try
            {
                cmbRole.Items.Clear();
                cmbRole.Items.Add(new ComboBoxItemEdit { Text = "Admin", Value = 1 });
                cmbRole.Items.Add(new ComboBoxItemEdit { Text = "Employee", Value = 2 });
                cmbRole.DisplayMember = "Text";
                cmbRole.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData()
        {
            try
            {
                string sql = "SELECT * FROM users WHERE id = " + UserId;
                var dataTable = DbAccess.ExecuteQueryTable(sql);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    var row = dataTable.Rows[0];
                    
                    txtFullName.Text = row["full_name"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtUsername.Text = row["username"].ToString();
                    txtPassword.Text = row["password"].ToString();
                    txtMobile.Text = row["mobile"].ToString();
                    txtNid.Text = row["nid"].ToString();
                    txtAddress.Text = row["address"].ToString();
                    chkIsActive.Checked = Convert.ToBoolean(row["is_active"]);

                    int roleId = Convert.ToInt32(row["role_id"]);
                    for (int i = 0; i < cmbRole.Items.Count; i++)
                    {
                        var item = (ComboBoxItemEdit)cmbRole.Items[i];
                        if (item.Value == roleId)
                        {
                            cmbRole.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                UpdateUser();
            }
        }

        private bool ValidateFields()
        {
            ClearErrorHighlighting();
            ClearErrorMessages();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                ShowError(txtFullName, lblFullNameError, "Full Name is required");
                isValid = false;
            }
            else if (txtFullName.Text.Length < 2 || txtFullName.Text.Length > 100)
            {
                ShowError(txtFullName, lblFullNameError, "Full Name must be between 2 and 100 characters");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowError(txtEmail, lblEmailError, "Email is required");
                isValid = false;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                ShowError(txtEmail, lblEmailError, "Please enter a valid email address");
                isValid = false;
            }
            else if (IsEmailExists(txtEmail.Text))
            {
                ShowError(txtEmail, lblEmailError, "Email already exists in the system");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError(txtUsername, lblUsernameError, "Username is required");
                isValid = false;
            }
            else if (txtUsername.Text.Length < 3 || txtUsername.Text.Length > 50)
            {
                ShowError(txtUsername, lblUsernameError, "Username must be between 3 and 50 characters");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9_]+$"))
            {
                ShowError(txtUsername, lblUsernameError, "Username can only contain letters, numbers, and underscores");
                isValid = false;
            }
            else if (IsUsernameExists(txtUsername.Text))
            {
                ShowError(txtUsername, lblUsernameError, "Username already exists in the system");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError(txtPassword, lblPasswordError, "Password is required");
                isValid = false;
            }
            else if (txtPassword.Text.Length < 4)
            {
                ShowError(txtPassword, lblPasswordError, "Password must be at least 4 characters");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                ShowError(txtMobile, lblMobileError, "Mobile number is required");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtMobile.Text, @"^01[3-9]\d{8}$"))
            {
                ShowError(txtMobile, lblMobileError, "Please enter a valid Bangladesh mobile number (e.g., 01712345678)");
                isValid = false;
            }
            else if (IsMobileExists(txtMobile.Text))
            {
                ShowError(txtMobile, lblMobileError, "Mobile number already exists in the system");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNid.Text))
            {
                ShowError(txtNid, lblNidError, "NID is required");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtNid.Text, @"^\d{10}$|^\d{13}$|^\d{17}$"))
            {
                ShowError(txtNid, lblNidError, "NID must be 10, 13, or 17 digits");
                isValid = false;
            }
            else if (IsNidExists(txtNid.Text))
            {
                ShowError(txtNid, lblNidError, "NID already exists in the system");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                ShowError(txtAddress, lblAddressError, "Address is required");
                isValid = false;
            }
            else if (txtAddress.Text.Length < 10 || txtAddress.Text.Length > 255)
            {
                ShowError(txtAddress, lblAddressError, "Address must be between 10 and 255 characters");
                isValid = false;
            }

            if (cmbRole.SelectedItem == null)
            {
                ShowError(cmbRole, lblRoleError, "Please select a role");
                isValid = false;
            }

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                return emailRegex.IsMatch(email);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Database error during email check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool IsEmailExists(string email)
        {
            try
            {
                string sql = "SELECT email FROM users WHERE email = '" + email.Replace("'", "''") + "' AND id != " + UserId;
                var dataTable = DbAccess.ExecuteQueryTable(sql);
                
                return dataTable != null && dataTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during email check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false; 
        }

        private bool IsUsernameExists(string username)
        {
            try
            {
                string sql = "SELECT username FROM users WHERE username = '" + username.Replace("'", "''") + "' AND id != " + UserId;
                var dataTable = DbAccess.ExecuteQueryTable(sql);
                
                return dataTable != null && dataTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during username check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false; 
        }

        private bool IsMobileExists(string mobile)
        {
            try
            {
                string sql = "SELECT mobile FROM users WHERE mobile = '" + mobile.Replace("'", "''") + "' AND id != " + UserId;
                var dataTable = DbAccess.ExecuteQueryTable(sql);
                
                return dataTable != null && dataTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during mobile number check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool IsNidExists(string nid)
        {
            try
            {
                string sql = "SELECT nid FROM users WHERE nid = '" + nid.Replace("'", "''") + "' AND id != " + UserId;
                var dataTable = DbAccess.ExecuteQueryTable(sql);
                
                return dataTable != null && dataTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during NID check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false; 
        }

        private void ShowError(Control control, Label errorLabel, string message)
        {
            control.BackColor = Color.LightPink;
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void ClearErrorHighlighting()
        {
            txtFullName.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            txtMobile.BackColor = Color.White;
            txtNid.BackColor = Color.White;
            txtAddress.BackColor = Color.White;
            cmbRole.BackColor = Color.White;
        }

        private void ClearErrorMessages()
        {
            lblFullNameError.Text = "";
            lblFullNameError.Visible = false;
            lblEmailError.Text = "";
            lblEmailError.Visible = false;
            lblUsernameError.Text = "";
            lblUsernameError.Visible = false;
            lblPasswordError.Text = "";
            lblPasswordError.Visible = false;
            lblMobileError.Text = "";
            lblMobileError.Visible = false;
            lblNidError.Text = "";
            lblNidError.Visible = false;
            lblAddressError.Text = "";
            lblAddressError.Visible = false;
            lblRoleError.Text = "";
            lblRoleError.Visible = false;
        }

        private void UpdateUser()
        {
            try
            {
                string fullName = txtFullName.Text.Replace("'", "''");
                string email = txtEmail.Text.Replace("'", "''");
                string username = txtUsername.Text.Replace("'", "''");
                string password = txtPassword.Text.Replace("'", "''");
                string mobile = txtMobile.Text.Replace("'", "''");
                string nid = txtNid.Text.Replace("'", "''");
                string address = txtAddress.Text.Replace("'", "''");
                int isActive = chkIsActive.Checked ? 1 : 0;
                int id = UserId;

                var selectedRole = (ComboBoxItemEdit)cmbRole.SelectedItem;
                int roleId = selectedRole.Value;

                string sql = $@"UPDATE users SET full_name = '{fullName}', email = '{email}', username = '{username}',password = '{password}', 
                role_id = {roleId}, mobile = '{mobile}', nid = '{nid}',address = '{address}',is_active = {isActive} WHERE id = {id}";


                int result = DbAccess.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    UserAdmin.RefreshUserData();
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            ClearErrorHighlighting();
            ClearErrorMessages();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtMobile.Text) && txtMobile.Text.Length >= 4)
            {
                string mobileLast4 = txtMobile.Text.Substring(txtMobile.Text.Length - 4);
                string newPassword = txtUsername.Text + "@" + mobileLast4;
                txtPassword.Text = newPassword;
                MessageBox.Show("Password generated successfully!", "Password Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter username and mobile number first.", "Cannot Generate Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

} 
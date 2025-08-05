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
    public partial class FormAddUser : Form
    {
        public DbAccess DbAccess { get; set; }
        public UserControlAdmin UserAdmin { get; set; }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        public FormAddUser()
        {
            InitializeComponent();
        }

        public FormAddUser(DbAccess dbAccess, UserControlAdmin userAdmin) : this()
        {
            this.DbAccess = dbAccess;
            this.UserAdmin = userAdmin;
            LoadRoles();
        }

        private void LoadRoles()
        {
            try
            {
                cmbRole.Items.Clear();
                cmbRole.Items.Add(new ComboBoxItem { Text = "Admin", Value = 1 });
                cmbRole.Items.Add(new ComboBoxItem { Text = "Employee", Value = 2 });
                cmbRole.DisplayMember = "Text";
                cmbRole.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SaveUser();
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
            catch (Exception ex)
            {
                MessageBox.Show("Database error during email check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool IsEmailExists(string email)
        {
            try
            {
                string sql = "SELECT email FROM users WHERE email = '" + email.Replace("'", "''") + "'";
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
                string sql = "SELECT username FROM users WHERE username = '" + username.Replace("'", "''") + "'";
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
                string sql = "SELECT mobile FROM users WHERE mobile = '" + mobile.Replace("'", "''") + "'";
                var dataTable = DbAccess.ExecuteQueryTable(sql);

                return dataTable != null && dataTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error during Mobile number check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool IsNidExists(string nid)
        {
            try
            {
                string sql = "SELECT nid FROM users WHERE nid = '" + nid.Replace("'", "''") + "'";
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
            lblMobileError.Text = "";
            lblMobileError.Visible = false;
            lblNidError.Text = "";
            lblNidError.Visible = false;
            lblAddressError.Text = "";
            lblAddressError.Visible = false;
            lblRoleError.Text = "";
            lblRoleError.Visible = false;
        }

        private void SaveUser()
        {
            try
            {
                string fullName = txtFullName.Text.Replace("'","''");
                string email = txtEmail.Text.Replace("'", "''");
                string username = txtUsername.Text.Replace("'","''");
                string mobile = txtMobile.Text.Replace("'", "''");
                string nid = txtNid.Text.Replace("'", "''");
                string address = txtAddress.Text.Replace("'", "''");
                int isActive = chkIsActive.Checked ? 1 : 0; 


                string mobileLast4 = mobile.Substring(txtMobile.Text.Length - 4);
                string password = username + "@" + mobileLast4;

                var selectedRole = (ComboBoxItem)cmbRole.SelectedItem;
                int roleId = selectedRole.Value;

                string sql = $@"INSERT INTO users (full_name, email, username, password, role_id, mobile, nid, address, created_date, is_active) 
                              VALUES ('{fullName}', '{email}', '{username}', '{password}', {roleId}, '{mobile}', '{nid}', '{address}', GETDATE(), {isActive})";

                

                int result = DbAccess.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show($"User created successfully!\n\nUsername: {txtUsername.Text}\nPassword: {password}\n\nPlease note down the password for the user.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UserAdmin.RefreshUserData();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            chkIsActive.Checked = true;
            ClearErrorHighlighting();
            ClearErrorMessages();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
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
    public partial class FormAddCustomer : Form
    {
        public DbAccess DbAccess { get; set; }
        public event EventHandler CustomerAdded;

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        public FormAddCustomer(DbAccess dbAccess) : this()
        {
            this.DbAccess = dbAccess;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMobile.Text))
                {
                    MessageBox.Show("Please enter mobile number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMobile.Focus();
                    return;
                }

                string name = txtName.Text.Replace("'", "''").Trim();
                string mobile = txtMobile.Text.Replace("'", "''").Trim();

                string sql = $"INSERT INTO customer (name, mobile) VALUES ('{name}', '{mobile}')";
                int result = DbAccess.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
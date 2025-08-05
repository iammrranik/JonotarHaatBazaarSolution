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
    public partial class FormEmployee : Form
    {
        public FormLogin FormLogin { get; set; }
        public DbAccess DbAccess { get; set; }
        public string Username { get; set; }
        public DataTable DataTable { get; set; }
        public FormEmployee()
        {
            InitializeComponent();
        }

        public FormEmployee(DbAccess dbAccess, FormLogin formLogin, string username) : this()
        {
            this.DbAccess = dbAccess;
            this.FormLogin = formLogin;
            this.Username = username;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from users where username = '" + this.Username + "';";
                this.DataTable = this.DbAccess.ExecuteQueryTable(sql);
                if (this.DataTable != null && DataTable.Rows.Count > 0)
                {
                    this.lblWelcome.Text = "Welcome, " + this.DataTable.Rows[0]["full_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in loading system.\n" + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to logout?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                this.FormLogin.Show();
            }
        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure to close application?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                //try
                //{
                    this.DbAccess.CloseConnection();
                //}
                //catch (Exception ex)
                //{
                    //MessageBox.Show("An error has occurred in closing system.\n" + ex.Message);
                //}
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
                this.FormLogin.Close();
                Application.Exit();
            //}
            //catch (Exception ex)
            //{
                //MessageBox.Show("An error has occurred in closing database system.\n" + ex.Message);
            //}
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select id from users where username = '" + this.Username + "';";
                DataTable userTable = this.DbAccess.ExecuteQueryTable(sql);
                
                if (userTable != null && userTable.Rows.Count > 0)
                {
                    int userId = Convert.ToInt32(userTable.Rows[0]["id"]);
                    FormAddSale formAddSale = new FormAddSale(this.DbAccess, userId, this);
                    this.Hide();  
                    formAddSale.Show();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Add Sale form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                FormSalesReport formSalesReport = new FormSalesReport(this.DbAccess, this);
                this.Hide(); 
                formSalesReport.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Sales Report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

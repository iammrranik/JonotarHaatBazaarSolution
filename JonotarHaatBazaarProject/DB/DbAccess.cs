using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonotarHaatBazaarProject.DB
{
    public class DbAccess
    {
        //private SqlConnection sqlcon;
        //private SqlCommand sqlcom;
        //private SqlDataAdapter sda;
        //private DataSet ds;
        //private SqlDataReader sdr;
        //internal DataTable dt;

        public SqlConnection Sqlcon { set; get; }
        public SqlCommand Sqlcom { set; get; }
        public SqlDataAdapter Sda { set; get; }
        public DataSet Ds { set; get; }
        public SqlDataReader Sdr { set; get; }

        public DbAccess()
        {
            try
            {
                this.Sqlcon = new SqlConnection(@"Data Source=UNKNOWN\DB;Initial Catalog=DB;User ID=sa;Password=Iamac0der;Encrypt=False");
                //this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP\DB;Initial Catalog=JonotarHaatBazaar;User ID=sa;Password=sa;Encrypt=False");
                //this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-41QHCLF\DB;Initial Catalog=JonotarHaatBazaar;Persist Security Info=True;User ID=sa;Password=Aburajin@1;Encrypt=False");
                Sqlcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in opening the database system, please try again.\n" + ex.Message);
            }
        }

        //private void QueryText(string query)
        //{
        //    this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        //}

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in the database system, please try again.\n" + ex.Message);
                return null;
            }
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in the database system, please try again.\n" + ex.Message);
                return null;
            }
        }

        public int ExecuteDMLQuery(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
                int u = this.Sqlcom.ExecuteNonQuery();
                return u;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in the database system, please try again.\n" + ex.Message);
                return -1;
            }
        }

        public int ExecuteRowCountQuery(string sql)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred counting row from the database system, please try again.\n" + ex.Message);
                return -1;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (this.Sqlcon != null && this.Sqlcon.State == ConnectionState.Open)
                {
                    this.Sqlcon.Close();
                    this.Sqlcon.Dispose();
                    Sqlcon = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred in closing database system, please try again.\n" + ex.Message);
            }
        }
    }
}

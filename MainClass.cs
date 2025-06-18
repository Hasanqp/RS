using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS
{
    public class MainClass
    {
        public static readonly string conString = "Data Source=DESKTOP-N863S34\\SQLEXPRESS;Initial Catalog=RSDB;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";
        public static SqlConnection con = new SqlConnection(conString);


        //Mehtod to check user validation

        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"select * from users where username ='" + user + 
                "' and upassword ='" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }
            return isValid;
        }

        // Create property for username

        public static string user;

        public static string USER
        {
            get {  return user; }
            private set { user = value; }
        }

        // Mathod for curd operation

        public static int SQl(string qry, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach(DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();

            }

            return res;
        }
        // For loading data from database

        public static void LoadData(string qry, DataGridView gv, ListBox ld)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int i = 0; i < ld.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)ld.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    }
}

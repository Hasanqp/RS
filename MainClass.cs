using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS
{
    public class MainClass
    {
        public static readonly string conString = "Data Source=DESKTOP-N863S34\\SQLEXPRESS;Initial Catalog=RSDB;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";
        public static SqlConnection con = new SqlConnection(conString);


        //Mehtod to check user validation

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            string qry = @"select * from users where username ='" + username + 
                "' and upassword ='" + password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}

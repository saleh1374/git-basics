using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace terminal1._0
{
    class Managment
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TerminalSystem;Integrated Security=True");
        private void UpdatePass(string userName, string pass)
        {
            Security security = new Security();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update tblUsers set User_Pass=@User_Pass where User_Name=@User_Name";
            cmd.Connection = con;
            cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = userName;
            cmd.Parameters.Add("@User_Pass", SqlDbType.NVarChar).Value = security.calculateMD5Hash(pass);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdminApp
{
    public class AdminModel
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-5SF3J80\\SQLEXPRESS;database=DemoTestOnline;uid=sa;pwd=123456");
            return conn;
        }
        public Staff CheckLogin(string u,string p)
        {
            Staff staff = null;
            string sql = "SELECT * FROM tblStaff WHERE username=@u and password=@p";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", u);
            cmd.Parameters.AddWithValue("@p", p);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                staff = new Staff();
                staff.UserName = rd.GetString(0);
                staff.Role = rd.GetInt32(2);
            }
            cmd.Connection.Close();
            return staff;
        }
    }
}

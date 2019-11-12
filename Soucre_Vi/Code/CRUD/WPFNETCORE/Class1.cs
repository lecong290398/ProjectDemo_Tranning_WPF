using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WPFNETCORE
{
    class Class1
    {
        //chuoi ket noi
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\LocalDB;Initial Catalog=demo;Integrated Security=True");

        private void moConnect()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void dongConnect()
        {
            if(con.State == System.Data.ConnectionState.Closed )
            {
                con.Close();
            }
        }
        //thuc thi du lieu
        public Boolean thucthi(string cmd)
        {
            moConnect();
            Boolean check = false;
            try
            {
                
                SqlCommand cmds = new SqlCommand(cmd,con);
                cmds.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            dongConnect();
            return check;
        }
        //doc du lieu
        public DataTable docDate(string cmd)
        {
            moConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter d = new SqlDataAdapter(cmds);
                d.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            dongConnect();
            return dt;
        }
    }
}

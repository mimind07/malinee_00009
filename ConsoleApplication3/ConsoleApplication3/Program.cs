using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System.Data.SqlClient;
    class Program
    {
        static void Main(string[] args)
        {
            String conStr = @"Data Source=LAB13214;Initial Catalog=myDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            Console.WriteLine(con.ServerVersion.ToString());
            //String sqlINSERT = "INSERT INTO customer Values (4,'AAA','0896578915')";
            //SqlCommand cmINSERT = new SqlCommand(sqlINSERT, con);
            //cmINSERT.ExecuteNonQuery();

            String sqlUPDATE = "UPDATE customer SET name='XYZ' WHERE id=5";
            SqlCommand cmUPDATE = new SqlCommand(sqlUPDATE, con);
            cmUPDATE.ExecuteNonQuery();


            
            //String sqlDel ="DELETE form customer WHERE id=4";
            //SqlCommand cmDelete = new SqlCommand(sqlDelete, con);
            //cmDelete.ExecuteNonQuery();


            SqlCommand cm = new SqlCommand("Select*From Customer",con);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                String data = dr["ID"].ToString() + ":";
                data += dr["Name"].ToString() + ":";
                data += dr["Tel"].ToString() + ":";
                Console.WriteLine(data);
            }
            con.Close();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace frm
{
    internal class Class1
    {
        public static List<Class1> c = new List<Class1>();

        public string email { get; set; }
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        public string dob { get; set; }
        public string dor { get; set; }
        public string phone { get; set; }
       
        
        public void save() 
        {

            string path = @"Server = DESKTOP-2PLFE08\SQLEXPRESS; Database = csharp; Integrated Security = true;";
            SqlConnection con = new SqlConnection(path);
            string query = "insert into datatable values ('" + this.email + "', '" + this.fName + "', '" + this.mName + "', '" + this.lName + "', '" + this.dob + "', '" + this.dor + "', '" + this.phone + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            };
            con.Close();
            
        }

        public static List<Class1> getall()
        {
            List<Class1> c = new List<Class1>();
            string path = @"Server = DESKTOP-2PLFE08\SQLEXPRESS; Database = csharp; Integrated Security = true;";
            SqlConnection con = new SqlConnection(path);
            string query = "select * from datatable;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataReader dataread = cmd.ExecuteReader();
                while (dataread.Read())
                {
                    Class1 item = new Class1();
                    item.email = (string)dataread["email"];
                    item.fName = (string)dataread["fName"];
                    item.mName = (string)dataread["mName"];
                    item.lName = (string)dataread["lName"];
                    item.dob = (string)dataread["dob"];
                    item.dor = (string)dataread["dor"];
                    item.phone = (string)dataread["phone"];
                }
            }
            catch(Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            return c;
        }
        public static Class1 findOne(String name)
        {
            List<Class1> c = new List<Class1>();
            string path = @"Server = DESKTOP-2PLFE08\SQLEXPRESS; Database = csharp; Integrated Security = true;";
            SqlConnection con = new SqlConnection(path);
            string query = "select * from datatable;";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            try
            {
                SqlDataReader dataread = cmd.ExecuteReader();
                while (dataread.Read())
                {
                    Class1 item = new Class1();
                    item.email = (string)dataread["email"];
                    item.fName = (string)dataread["fName"];
                    item.mName = (string)dataread["mName"];
                    item.lName = (string)dataread["lName"];
                    item.dob = (string)dataread["dob"];
                    item.dor = (string)dataread["dor"];
                    item.phone = (string)dataread["phone"];
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            };
            con.Close();
            return c.Find(a => a.fName == name);
        }
          
        

    }
}

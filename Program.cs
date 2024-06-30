using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SQLConnectionADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }
        static void Connection()
        {
            //string cs = "Data Source=INNO1-9005;Initial Catalog= ado_db;Integrated Security=true;";
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection has been Created Successfully.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

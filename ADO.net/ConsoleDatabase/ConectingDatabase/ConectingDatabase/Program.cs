using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConectingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=.\\SQLExpress; Database=sabhav;User Id=sa;Password=root;";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                Console.WriteLine("Connection Sucessfull...!\nConnectionString is : " + con.ConnectionString);
                Console.WriteLine("Connection Timeout :" + con.ConnectionTimeout);
                Console.WriteLine("Connected Database :" + con.Database);
                Console.WriteLine("Connected DataSource :" + con.DataSource);
                Console.WriteLine("Credential :" + con.Credential);
                Console.WriteLine("Schema information of Datasource : " + con.GetSchema());
                Console.WriteLine("the state of the SqlConnection :" + con.State);
                Console.WriteLine("the version of the instance of SQL Server : " + con.ServerVersion);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            Console.Read();
        }
    }
}

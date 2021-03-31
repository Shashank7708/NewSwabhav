using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TransactionBetweenMerchantAndCustomer
{
    class Operations
    {
        public List<Merchant> getTable()
        {
            using( var connect=new SqlConnection(Helper.CnnVal("Sample")))
            {
                Console.WriteLine("Connection Established");
                Console.WriteLine("Database:"+connect.Database);
                Console.WriteLine("Connection State:"+connect.State);
               
             var output= connect.Query<Merchant>("Select * from Merchant").ToList();
                return output;

                //var output1 = connect.Query<MerchantAndCustomer>("select * from Merchant").ToList();
            }
        }
        public List<Customer> getCustomers()
        {
            using(var connect=new SqlConnection(Helper.CnnVal("Sample")))
            {
                var output = connect.Query<Customer>("select * from Customer").ToList();
                return output;
            }
        }

        public bool transaction(int custid,int merchantid,double amt)
        {
          
                using (var connect = new SqlConnection(Helper.CnnVal("Sample")))
            {
               
                connect.Open();

                var transaction = connect.BeginTransaction();

                    try
                    {
                    
                   SqlCommand cmd=new SqlCommand($"update Customer set balance=balance-{amt} where id={custid}", connect,transaction);
                    cmd.ExecuteNonQuery();
                    
                   SqlCommand cmd2=new SqlCommand($"update Merchant set balance=balance+{amt} where id={merchantid}", connect,transaction);
                    cmd2.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                    }

                    catch (Exception e)
                    {
                    transaction.Rollback();
                    Console.WriteLine(e.Message);
                    
                    }
                

                }
            return false;

        }
          
         
        
    }

}

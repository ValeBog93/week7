using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Week7
{
    public static class Ex1
    {
        public static void Run()
        {
            try
            {
                ExecuteSqlQuerry();
            }
            catch (SqlException e) when (e.Class > 19)
            {
                Console.WriteLine("abbiamo l'errore fatale");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Errore durante la query");

            }
        }

        public static void ExecuteSqlQuerry()
        {
            SqlConnection connection = new SqlConnection(@"Data Soure =.; Database=NONFUZIONA;Connection Timeunt = 1");
            connection.Open();
        }
    }
}
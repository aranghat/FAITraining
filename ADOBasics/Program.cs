using System;
using System.Data;
using System.Data.SqlClient;


namespace ADOBasics
{
    class Program
    {
        static string connectionString = "Integrated Security=SSPI" +
            ";Database=SREE_EMPLOYEEDB;Server=.\\SQLEXPRESS";

        //static string connectionString = "Integrated Security=False" +
            //";Database=SREE_EMPLOYEEDB;Server=.\\SQLEXPRESS;uid=sa;Password=abcd@1234";
        static void Main(string[] args)
        {
            long id = 1;
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                /* SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count(*) from products";// where id = @id";
                cmd.Connection = con;

               cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["ID"]} {reader["Name"]}");
                }

               int totalProducts =  (int)cmd.ExecuteScalar();
                Console.WriteLine($"Total PRoducts = {totalProducts}");

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO PRODUCTS(Name,UnitPrice,TotalStock) VALUES(@Name,@UnitPrice,@TotalStock)";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@Name", "4GB RAM");
                cmd.Parameters.AddWithValue("@UnitPrice", 4500);
                cmd.Parameters.AddWithValue("@TotalStock", 3);

                int totalRowsInserted = cmd.ExecuteNonQuery();
                Console.WriteLine($"Total Products Added : {totalRowsInserted}");
                using (var transaction = con.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM ORDERS WHERE ID = @ID";
                    cmd.Connection = con;
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@ID", 10);

                    int toalRowsAffected = cmd.ExecuteNonQuery();

                    Console.WriteLine($"Total Records deleted : {toalRowsAffected}");
                    Console.Write("Do you want to commit this transaction (Y/N) : ");

                    var userChoice = Console.ReadLine();

                    if (userChoice == "Y")
                        transaction.Commit();
                    else
                        transaction.Rollback();

                }*/

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spCreateOrder";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProductId", 2);
                cmd.Parameters.AddWithValue("@CustomerId", 1);
                cmd.Parameters.AddWithValue("@TotalQuantity", 2);

                cmd.Parameters.Add("@OrderId", SqlDbType.Int);
                cmd.Parameters["@OrderId"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                Console.WriteLine(cmd.Parameters["@OrderId"].Value);

            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;

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
            DataTable table = new DataTable();
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                #region ADO.NET BASICS
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

                }

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

                Console.WriteLine(cmd.Parameters["@OrderId"].Value);*/

                #endregion

                SqlCommand cmd   = new SqlCommand();
                cmd.CommandText  = "SELECT * FROM Customers";
                cmd.Connection   = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd); 
                da.Fill(table);
                //DisplayDataTable(table);

                //DisplayFilteredData(table);

                //AddNewCustomer(table);
                //UpdateCustomer(table);
                DeleteCustomer(table);
                Save(table);
            }

        }

        static void Save(DataTable table)
        {
            using (var con = new SqlConnection(connectionString))
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = con;
                insertCommand.CommandText = "INSERT INTO Customers(Name,Address) VALUES(@Name,@Address)";

                insertCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
                insertCommand.Parameters.Add("@Address", SqlDbType.VarChar, 500, "Address");

                SqlCommand updateCommand = new SqlCommand();
                updateCommand.Connection = con;
                updateCommand.CommandText = "UPDATE Customers SET Name = @Name, Address=@Address WHERE ID =@ID";
                updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
                updateCommand.Parameters.Add("@Address", SqlDbType.VarChar, 500, "Address");
                updateCommand.Parameters.Add("@ID", SqlDbType.Int,0, "ID");

                SqlCommand deleteCommand = new SqlCommand();
                deleteCommand.CommandText = "DELETE FROM Customers WHERE ID = @ID";
                deleteCommand.Connection = con;

                deleteCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");

                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = insertCommand;
                da.UpdateCommand = updateCommand;
                da.DeleteCommand = deleteCommand;

                da.Update(table);
            }

            DisplayDataTable(table);
        }

        static void DeleteCustomer(DataTable table)
        {
            Console.Write("Enter the Id : ");
            int customerId = int.Parse(Console.ReadLine());

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                if ((int)row["ID"] == customerId)
                {
                    table.Rows[i].Delete();
                }
            }

        }

        static void UpdateCustomer(DataTable table)
        {
            Console.Write("Enter the Id : ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter the new name : ");
            string newName = Console.ReadLine();

            //DataRow row = table.Rows[0];
            //row["Name"] = "Updated User";

            for(int i=0;i<table.Rows.Count;i++)
            {
                DataRow row = table.Rows[i];
                if((int)row["ID"] == customerId)
                {
                    row["Name"] = newName;
                }
            }
           
        }

        static void AddNewCustomer(DataTable table)
        {
            DataRow newRow = table.NewRow();
            newRow["Name"] = "Jhon";
            newRow["Address"] = "New Address";

            table.Rows.Add(newRow);

           // DisplayDataTable(table);
        }

        static void DisplayDataTable(DataTable table)
        {
            foreach (var col in table.Columns)
                Console.Write($"{col}\t");
            Console.WriteLine("\n------------------------------------------------\n");
            foreach(DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["ID"]}\t{row["Name"]}\t{row["Address"]}");
            }
        }

        static void DisplayFilteredData(DataTable table)
        {
            DataView view = table.DefaultView;
            //view.RowFilter = "Name='Bill' OR Name = 'Steve'";
            view.RowFilter = "Name LIKE 'S%'";

            DisplayDataTable(view.ToTable());
        }
    }
}

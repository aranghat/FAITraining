using HelloMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HelloMvc.Repo
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            using (var con = new SqlConnection(@"Integrated Security=SSPI;Server=.\SqlExpress;Database=SREE_EMPLOYEEDB"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from books", con);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book b = new Book();
                    b.Author = reader["Author"].ToString();
                    b.BookId = (int)reader["BookId"];
                    b.Name = reader["Name"].ToString();

                    books.Add(b);

                }
            }

            return books;
        }

        public Book Add(Book book)
        {
            return null;
        }
    }
}
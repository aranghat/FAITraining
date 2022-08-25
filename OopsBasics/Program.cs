using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            List<Book> booList = new List<Book>();

            Book book1 = new Book();
            //book1.setTitle("An");
            book1.Title = "Anngels and Demons";
            book1.Remarks = "Awsome book";

            //Console.WriteLine(book1.getTitle());
            Console.WriteLine(book1.Id);
            Console.WriteLine(book1.Title);
            //Book book3 = new Book("Dan Brown"
            //    ,"Angels and Demons");
           
            //Book book2 = new Book("Robin Sharma");
            //book2.title = "Monk who sold his ferrari";

            //Console.WriteLine(book1);
            //Console.WriteLine(book2);
            //Console.WriteLine(book3);

            //Console.ReadLine();
        }
    }
}

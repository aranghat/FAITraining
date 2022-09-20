using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetWebApiBasics.Controllers
{
    public class BooksController : ApiController
    {
        static List<Book> books = new List<Book>();

        public BooksController()
        {
            if(books.Count == 0)
            {
                books.Add(new Book { BookId = 1001, Name = "Angels and Demons", Author = "Dan Brown" });
                books.Add(new Book { BookId = 1002, Name = "Davinci Code", Author = "Dan Brown" });
                books.Add(new Book { BookId = 1003, Name = "Monk who sold his Ferrari", Author = "Robin Sharma" });
            }
        }

        public List<Book> Get()
        {
            return books;
        }

        public HttpResponseMessage Post(Book book)
        {
            var response = new HttpResponseMessage();

            if (book.BookId > 0)
            {
                books.Add(book);


                response.StatusCode = HttpStatusCode.Created;
                response.Content = new StringContent("Book got created");
            }
            else
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent("Book id cannot be less than 0");
            }

            return response;
        }

       public HttpResponseMessage Put(Book book)
       {
            HttpResponseMessage response = new HttpResponseMessage();

            if (books.Any(d => d.BookId == book.BookId))
            {
                var currentBook = books.First(d => d.BookId == book.BookId);
                currentBook.Name = book.Name;
                currentBook.Author = book.Author;
                response.StatusCode = HttpStatusCode.OK;
            }
            else
                response.StatusCode = HttpStatusCode.NotFound;
            return response;
       }
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var currentBook = books.FirstOrDefault(d => d.BookId == id);
            if (currentBook != null)
            {
                books.Remove(currentBook);
                response.StatusCode = HttpStatusCode.OK;
            }
            else
                response.StatusCode = HttpStatusCode.NotFound;

            return response;
        }
    }
}

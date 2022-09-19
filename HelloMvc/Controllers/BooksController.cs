using HelloMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMvc.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        static List<Book> books = new List<Book>();

        public BooksController()
        {
            if (books.Count == 0)
            {
                books.Add(new Book { BookId = 1001, Name = "Davinci Code"
                    , Author = "Dan Brown" , ImageUrl= "/Images/1.jpg"
                });
                books.Add(new Book { BookId = 1002, Name = "Angels and Demons", Author = "Dan Brown" ,ImageUrl = "/Images/2.jpg" });
                books.Add(new Book { BookId = 1003, Name = "The Monk Who Sold his Ferrari", Author = "Robin Sharma"
                , ImageUrl = "/Images/3.webp"
                });
            }
        }

        // GET: Books
        public ActionResult Index()
        {
            return View(books);
        }

        public ActionResult BookDetails(int id)
        {
            Book book = books
                .FirstOrDefault(d => d.BookId == id);
            return View(book);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult New(Book book)
        {
            if (ModelState.IsValid)
            {
                if (!books.Contains(book))
                    books.Add(book);
                else
                    ViewBag.Error = $"Book with the id : {book.BookId} exists";
            }
            return View();
        }
    }
}
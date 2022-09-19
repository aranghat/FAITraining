using HelloMvc.Models;
using HelloMvc.Repo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMvc.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        List<Book> books = new List<Book>();

        public BooksController()
        {
           
        }

        // GET: Books
        public ActionResult Index()
        {
             books = new BookRepository().GetBooks();
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
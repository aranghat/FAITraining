using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasics
{
    public class Book
    {
        //Data Members
        private int id;

        //Backing Field
        private string title;
        private string author;

        //Default Constructor
        public Book()
        {
            id = new Random()
                .Next(99, 999);
            Console.WriteLine("Default Constructor Called");
        }

        //Parametarized Constructor
        public Book(string author
                    ,string title) 
            : this()
        {
            this.author = author;
            this.title = title;
        }

        public Book(string author) 
            : this(author,"")
        {  }

        public override string ToString()
        {
            return $"Id : {id}, Title : {title} Author : {author}";
        }

        //Finalizer
        ~Book()
        {
            Console.WriteLine("Object is being removed");
        }

        //Read only properties
        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length >= 3)
                    title = value;
                else
                    throw new Exception("Title cannot be blank");
            }
        }

        //Auto Implemented Properties
        public string Remarks
        {
            get; set;
        }

        //public void setTitle(string title)
        //{
        //    if (title.Length >= 3)
        //        this.title = title;
        //    else
        //        throw new Exception("Title cannot be blank");
        //}

        //public string getTitle()
        //{
        //    return title;
        //}
    }
}

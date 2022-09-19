using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetWebApiBasics
{
    public class Book : IEquatable<Book>
    {
        [Required]
        public int BookId { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Should contain only alphabets")]
        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public bool Equals(Book other)
        {
            return this.BookId == other.BookId;
        }
    }
}
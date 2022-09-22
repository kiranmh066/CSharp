using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementEntity
{
    public class Book
    {
        public string BookAuthor { get; set; }

        public int BookCopies { get; set; }

        public int BookId { get; set; }

        public string BookName { get; set; }

       public  Book(string bookAuthor, int bookCopies, int bookId, string bookName)
        {
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.BookCopies = bookCopies;
            this.BookId = bookId;
        }
        public Book()
        {

        }


    }
}

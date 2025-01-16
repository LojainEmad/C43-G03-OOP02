using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OOP
{
    #region class Book
    public class Book
    {
        #region fields
        private string title;
        private string author;
        private string isbn;
        #endregion
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book() : this("Unknown", "Unknown", "000")
        {
        }
        public Book(string title) : this(title, "Unknown", "000")
        {
        }
        public Book(string title, string author) : this(title, author, "000")
        {
        }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
    #endregion

    #region EBOOK
    public class EBook : Book
    {
        public double FileSize { get; set; }
        public EBook(string title, string author, string isbn, double fileSize) : base(title, author, isbn)
        {
            
            if (fileSize < 0)
            {
                Console.WriteLine("fileSize cannot be negative.setting fileSize to default value (0).");
                fileSize = 0;
            }
            else
            {
                FileSize = fileSize;
            }
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"File Size for Ebook: {FileSize} MB");
            
        }
    }
    #endregion

    #region PrintedBook
    public class PrintedBook : Book
    {
        public int PageCount { get; set; }
        public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
        {
            if (pageCount < 0)
            {
                Console.WriteLine("Page count cannot be negative.setting page count to default value (0).");
                PageCount = 0;
            }
            else
            {
                PageCount = pageCount;
            }
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Page Count for printedBook: {PageCount} pages ");
           
        }
    }
    #endregion


}

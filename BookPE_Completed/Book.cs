using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPE_Completed
{
    /// <summary>
    /// Represents a book that someone has purchased and intends to read.
    /// </summary>
    internal class Book
    {
        // Private fields
        private string title;    
        private string author;   
        private int numPages;    
        private string owner;
        private int timesRead;

        // Properties are public so that outside classes can access them.

        /// <summary>
        /// Read-only property retrieves this book's title
        /// </summary>
        public string Title 
        {
            get 
            { 
                return title; 
            }
        }

        /// <summary>
        /// Read-only property retrieves this book's author
        /// </summary>
        public string Author
        {
            get { return author; }
        }

        /// <summary>
        /// Read-only property retrieves this book's page count
        /// </summary>
        public int NumPages
        {
            get { return numPages; }
        }

        /// <summary>
        /// Retrieves the owner (purchaser of the book) and sets that field. 
        /// Limitation: Cannot be null or empty string.
        /// </summary>
        public string Owner
        {
            get { return owner; }
            set
            {
                // ONLY if the value is not null or empty string
                if(value != null && value != "")
                {
                    owner = value;
                }                
            }
        }

        /// <summary>
        /// Retrieves the number of times that the owner has read this book and sets the field. 
        /// Limitation: Cannot reduce the value of timesRead.
        /// </summary>
        public int TimesRead
        {
            get { return timesRead; }
            set
            {
                // Only change this field IF the incoming value is larger than current
                if(value > timesRead)
                {
                    timesRead = value;
                }
            }
        }

        /// <summary>
        /// Has this book been read by the owner?
        /// </summary>
        public bool IsUsed
        {
            get
            {
                // Can do this:
                //if (timesRead > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

                // Or you can do this:
                //if (timesRead > 0)
                //{
                //    return true;
                //}

                //return false;

                // And you can also do this:
                return timesRead > 0;
            }
        }

        // Auto properties --> NOT permitted in 105!
        //public string Cover { get; set; }
        //public int MyProperty { get; }


        /// <summary>
        /// Constructs a Book object that the owner has never read.
        /// </summary>
        /// <param name="title">Title of the book</param>
        /// <param name="author">Author of the book</param>
        /// <param name="numPages">Number of pages in the book</param>
        /// <param name="owner">Purchaser of the book</param>
        public Book(string title, string author, int numPages, string owner)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.owner = owner;
            timesRead = 0;
        }


        /// <summary>
        /// Displays information about this Book object in the console window.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Pages: {numPages}");
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"Times Read: {timesRead}");
            Console.WriteLine($"Is Used: {IsUsed}");
        }
    }
}

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

        // Properties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="numPages"></param>
        /// <param name="owner"></param>
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
            //Console.WriteLine($"Is Used: {IsUsed}");
        }

    }
}

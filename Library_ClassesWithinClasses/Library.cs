using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ClassesWithinClasses
{
    internal class Library
    {
        // Fields
        // Declare the array here
        private Book[] myBooks;


        // Constructor
        /// <summary>
        /// Instantiates a Library that contains 3 Books.
        /// </summary>
        public Library()
        {
            // Initialize the array here
            // DON'T do this (it re-declares the array):
            //Book[] myBooks = new Book[3];

            // Do THIS:  (initializes the array field)
            myBooks = new Book[5];

            // Direct instantiation into the array
            myBooks[0] = new Book();
            myBooks[1] = new Book("How to be a pest", "Dash the cat", 1);
            myBooks[2] = new Book("I LOVE candy!", "Zoe", 2);
            myBooks[3] = new Book("When your professor talks too much...", "Erin Cascioli", 627);
            myBooks[4] = new Book("Spells", "Winifred Sanderson", 1000, 15, 0);

            // OR you could instantiate via variables
            //Book defaultBook = new Book();
            //myBooks[0] = defaultBook;
            //Book dashBook = new Book("How to be a pest", "Dash the cat", 1);
            //myBooks[1] = dashBook;
            //Book zoeBook = new Book("I LOVE candy!", "Zoe", 2);
            //myBooks[2] = zoeBook;
            //Book erinBook = new Book("When your professor talks way too much...", "Erin Cascioli", 627);
            //myBooks[3] = erinBook;
            //Book hocusPocus = new Book("Spells", "Winifred Sanderson", 1000, 15, 0);
            //myBooks[4] = hocusPocus;
        }


        /// <summary>
        /// Prints the number of books in the library.
        /// </summary>
        public void NumberOfBooksIPurchased()
        {
            Console.WriteLine("I own {0} books.", myBooks.Length);
        }


        /// <summary>
        /// Prints information about every Book in the library.
        /// </summary>
        public void PrintLibrary()
        {
            Console.WriteLine("These are the books in my library: ");

            // Iterate through every book on my shelf
            //   and print information about it
            for (int i = 0; i < myBooks.Length; i++)
            {
                myBooks[i].Print();
            }
        }


        /// <summary>
        /// Searches for a titled book in the library.
        /// </summary>
        /// <param name="titleFromParam">Title of the desired book.</param>
        /// <returns>True if the book is in the library, false otherwise.</returns>
        public bool SearchForBook(string titleFromParam)
        {
            // PSEUDOCODE:
            // Iterate through all books in the array
            //     Does the book title match the parameter?
            //     Yes --> true
            // After the search, did not find book --> false
            // Return true or false

            // Start by assuming the book is NOT there.
            bool inLibrary = false;

            // Search through all books in the library
            for (int i = 0; i < myBooks.Length; i++)
            {
                // Wait...  I can't do this because title is private...
                // Check is the title matches this method's parameter
                /*
                if (titleFromParam == myBooks[i].title)
                {
                    inLibrary = true;
                }
                */
            }

            // Return the result.
            return inLibrary;
        }
    }
}

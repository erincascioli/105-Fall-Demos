namespace BookPE_Completed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable block to gather user input
            string bookTitle;
            string bookAuthor;
            int bookPages;
            string bookOwner;
            string userChoice = null;
            Book newBook;


            // Welcome user and gather input
            Console.WriteLine("Welcome to Book Simulator 2023!");

            Console.Write($"Enter the title of your book: ");
            bookTitle = Console.ReadLine().Trim();
            Console.Write($"Enter the author of {bookTitle}: ");
            bookAuthor = Console.ReadLine().Trim();
            Console.Write($"Enter the number of pages in {bookTitle}: ");
            bookPages = int.Parse(Console.ReadLine().Trim());
            Console.Write($"Who currently owns {bookTitle}? ");
            bookOwner = Console.ReadLine().Trim();

            // Initialize Book object
            newBook = new Book(bookTitle, bookAuthor, bookPages, bookOwner);

            // Give instructions
            Console.WriteLine("\nYou may now type any of the following commands:");
            Console.WriteLine("[title, author, pages, owner, read, used, print, quit] \n");

            // Loop for menu choices here
            while (userChoice != "quit")
            {
                Console.Write("What would you like to do? ");
                userChoice = Console.ReadLine().ToLower().Trim();

                switch (userChoice)
                {
                    case "title":
                        // Call property here
                        break;

                    case "author":
                        // Call property here
                        break;

                    case "pages":
                        // Call property here
                        break;

                    case "owner":
                        Console.Write("Do you want to change the owner? ");
                        userChoice = Console.ReadLine().ToLower().Trim();

                        if (userChoice == "no")
                        {
                            // Call property here
                        }
                        else if (userChoice == "yes")
                        {
                            Console.Write("Who is the new owner? ");
                            userChoice = Console.ReadLine().Trim();

                            // Call property here

                            Console.WriteLine($"The book's new owner is {userChoice}.");
                        }

                        break;

                    case "read":
                        // Call property here
                        break;

                    case "used":
                        // Call property here
                        break;

                    case "print":
                        // Call Print method here
                        break;

                    case "quit":
                        Console.WriteLine("Thank you for trying Book Simulator!");
                        break;
                }
            }
        }
    }
}
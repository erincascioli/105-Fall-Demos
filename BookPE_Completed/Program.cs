namespace BookPE_Completed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variable block to gather user input
            string bookTitle;
            string bookAuthor;
            int bookPages;
            string bookOwner;
            string userChoice = null!;
            Book purchasedBook = null!;

            // ----------------------------------------------------------------
            // Welcome user and gather input for Book initialization
            Console.WriteLine("Welcome to Book Simulator 2023!");

            Console.Write($"Enter the title of your book: ");
            bookTitle = Console.ReadLine()!.Trim();
            Console.Write($"Enter the author of {bookTitle}: ");
            bookAuthor = Console.ReadLine()!.Trim();
            Console.Write($"Enter the number of pages in {bookTitle}: ");
            bookPages = int.Parse(Console.ReadLine()!.Trim());
            Console.Write($"Who currently owns {bookTitle}? ");
            bookOwner = Console.ReadLine()!.Trim();

            // Initialize Book object
            purchasedBook = new Book(bookTitle, bookAuthor, bookPages, bookOwner);

            // ----------------------------------------------------------------
            // Give instructions
            Console.WriteLine("\nYou may now type any of the following commands:");
            Console.WriteLine("[title, author, pages, owner, read, used, print, quit] \n");

            // Loop for menu choices here
            while (userChoice != "quit")
            {
                // Prompt for choice
                Console.Write("\nWhat would you like to do? ");
                userChoice = Console.ReadLine()!.ToLower().Trim();

                // Act on user's choice
                switch (userChoice)
                {
                    case "title":
                        // Call the property here:
                        Console.WriteLine(purchasedBook.Title);
                        break;

                    case "author":
                        // Call the property here:
                        Console.WriteLine(purchasedBook.Author);
                        break;

                    case "pages":
                        // Call the property here:
                        Console.WriteLine(purchasedBook.NumPages);
                        break;

                    case "owner":
                        Console.Write("Do you want to change the owner? ");
                        userChoice = Console.ReadLine()!.ToLower().Trim();

                        if (userChoice == "no")
                        {
                            // Call the property here:
                            Console.WriteLine(purchasedBook.Owner);
                        }
                        else if (userChoice == "yes")
                        {
                            Console.Write("Who is the new owner? ");
                            userChoice = Console.ReadLine()!.Trim();

                            // Set the book's new owner here:
                            purchasedBook.Owner = userChoice;

                            Console.WriteLine($"The book's new owner is {userChoice}.");
                        }

                        break;

                    case "read":
                        // Can do one of the following here:
                        //purchasedBook.TimesRead = purchasedBook.TimesRead + 1;
                        // OR
                        //purchasedBook.TimesRead += 1;
                        // OR
                        purchasedBook.TimesRead++;
                        break;

                    case "used":
                        // Call the property here:
                        Console.WriteLine(purchasedBook.IsUsed);
                        break;

                    case "print":
                        // Call the Print method here:
                        purchasedBook.Print();
                        break;

                    case "quit":
                        Console.WriteLine("Thank you for trying Book Simulator!");
                        break;
                }
            }
        }
    }
}

// Erin Cascioli
// 10/16/23
// Demo: Static methods with parameters and return types

namespace StaticMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Display the appropriate headline and run a for loop that fulfills
            //   the requirement
            // ----------------------------------------------------------------

            // 0 through 10 in ascending order
            DisplayHeadline("Print 0 - 10 on different lines", ConsoleColor.DarkCyan);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Multiples of 5 from 5 through 50
            DisplayHeadline("Print multiples of 5 on different lines", ConsoleColor.DarkMagenta);
            for (int i = 5; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }

            // 10 through 0 backwards
            DisplayHeadline("Print 10 - 0 backwards on different lines", ConsoleColor.Red);
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            // ----------------------------------------------------------------
            // Call additional written methods
            // ----------------------------------------------------------------

            // Prints "random" words based on the incoming argument
            DisplayHeadline("Print 'random' words", ConsoleColor.Red);
            PrintRandomWord(1);
            PrintRandomWord(2);
            PrintRandomWord(3);
            PrintRandomWord(5);

            // NOTICE that this is NOT inside of a Console.WriteLine statement because
            //   PrintRandomWord returns nothing!  The method itself does the printing!

            // Adds three integers and prints to console
            DisplayHeadline("Add three integers", ConsoleColor.DarkGreen);
            int answer = AddValues(2, 3, 4);
            Console.WriteLine(answer);

            // OR you can do this:
            Console.WriteLine(AddValues(10, 20, 30));
        }  // END MAIN


        /// <summary>
        /// Prints a visual divider in multiple colors with a custom headline
        /// </summary>
        /// <param name="textToDisplay">Text displayed in the custom headline</param>
        /// <param name="textColor">Text color</param>
        public static void DisplayHeadline(string textToDisplay, ConsoleColor textColor)
        {
            // Print a visual divider in yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...............................");

            // Print describing text in the custom color
            Console.ForegroundColor = textColor;
            Console.WriteLine(textToDisplay);

            // Print ending visual divider in yellow again
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...............................");

            // Prepare for following text to be white
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Adds three integer values
        /// </summary>
        /// <param name="num1">Value one</param>
        /// <param name="num2">Value two</param>
        /// <returns>Sum of the three values</returns>
        public static int AddValues(int num1, int num2, int num3)
        {
            // Add the 3 params and return the sum
            int sum = num1 + num2 + num3;
            return sum;
        }


        /// <summary>
        /// Prints one of three words depending on what is passed in.
        /// </summary>
        /// <param name="value">Integer between 1 (inclusive) and 3 (inclusive)</param>
        public static void PrintRandomWord(int value)
        {
            // Prints apple, banana or cat to the console window
            //   depending on the incoming value
            if (value == 1)
            {
                Console.WriteLine("apple");
            }
            else if (value == 2)
            {
                Console.WriteLine("banana");
            }
            else if (value == 3)
            {
                Console.WriteLine("cat");
            }
        }


        /// <summary>
        /// Returns one of three strings based on the incoming value.
        /// </summary>
        /// <param name="value">Determines the string that is returned</param>
        /// <returns>One of three strings: "apple", "banana" or "cat"</returns>
        public static string ReturnRandomWord(int value)
        {
            // Returns one of three strings depending on the incoming integer value
            if (value == 1)
            {
                return "apple";
            }
            else if (value == 2)
            {
                return "banana";
            }
            else
            {
                return "cat";
            }
        }
    }
}
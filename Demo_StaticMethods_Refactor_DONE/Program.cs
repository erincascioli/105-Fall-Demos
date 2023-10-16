
// Erin Cascioli
// 10/7/22
// Demo: Refactoring a program into static methods

namespace Demo_StaticMethods_Refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variable Block
            string userMenuChoice;
            double number1;
            double number2;
            double sum;
            double difference;
            double product;
            double quotient;

            // Present user with a menu of options
            // Ask for input
            // Present white text menu to user:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Here are your choices: ");
            Console.WriteLine("\tADDITION \t SUBTRACTION");
            Console.WriteLine("\tMULTIPLY \t DIVISION");
            Console.Write("Which option do you want? ");

            // Get user's menu choice in yellow
            // Re-display user choice for confirmation
            Console.ForegroundColor = ConsoleColor.Yellow;
            userMenuChoice = Console.ReadLine().ToUpper().Trim();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You chose " + userMenuChoice + "\n");

            // Determine which option the user chose and run appropriate code
            switch(userMenuChoice)
            {
                case "ADDITION":
                    // Display headline to introduce user to mathematical process
                    DisplayHeadline("ADDITION -------------------");

                    // Ask user for first and second values as doubles
                    number1 = PromptForDouble("  Enter the first number: ");
                    number2 = PromptForDouble("  Enter the second number: ");

                    // Display the result
                    sum = Addition(number1, number2);
                    Console.WriteLine("  The sum is " + sum);
                    break;

                case "SUBTRACTION":
                    // Display headline to introduce user to mathematical process
                    DisplayHeadline("SUBTRACTION -------------------");

                    // Ask user for first and second values as doubles
                    number1 = PromptForDouble("  Enter the first number: ");
                    number2 = PromptForDouble("  Enter the second number: ");

                    // Display the result
                    difference = Subtraction(number1, number2);
                    Console.WriteLine("  The difference is " + difference);
                    break;

                case "MULTIPLY":
                    // Display headline to introduce user to mathematical process
                    DisplayHeadline("MULTIPLICATION -------------------");

                    // Ask user for first and second values as doubles
                    number1 = PromptForDouble("  Enter the first number: ");
                    number2 = PromptForDouble("  Enter the second number: ");

                    // Display the result
                    product = Multiplication(number1, number2);
                    Console.WriteLine("  The product is " + product);
                    break;

                // This case now uses methods that we wrote.  Keeps program modular!
                case "DIVISION":
                    // Display headline to introduce user to mathematical process
                    DisplayHeadline("DIVISION -------------------");

                    // Ask user for first and second values as doubles
                    number1 = PromptForDouble("  Enter the first number: ");
                    number2 = PromptForDouble("  Enter the second number: ");

                    // Display the result
                    quotient = Division(number1, number2);
                    Console.WriteLine("  The quotient is " + quotient);
                    break;

                default:
                    Console.WriteLine(userMenuChoice + " is not a valid option.");
                    break;
            }
        }

        /// <summary>
        /// Prompts a user for a value, then parses to a double.
        /// </summary>
        /// <param name="prompt">Prompt for user.</param>
        /// <returns>User's entered value as a double.</returns>
        public static double PromptForDouble(string prompt)
        {
            // Display prompt in white
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(prompt);

            // Gather user's value in yellow
            Console.ForegroundColor = ConsoleColor.Green;
            double number = double.Parse(Console.ReadLine());

            // Set color back to White
            Console.ForegroundColor = ConsoleColor.White;

            // Return back to method call
            return number;
        }

        /// <summary>
        /// Displays a headline in cyan color
        /// </summary>
        /// <param name="headline">Headline to display</param>
        public static void DisplayHeadline(string headline)
        {
            // Display headline to introduce user to mathematical process
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(headline);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Divides 2 values. Both values must be doubles.
        /// </summary>
        /// <param name="num1">Divisor</param>
        /// <param name="num2">Dividend</param>
        /// <returns>Quotient; the answer of division process.</returns>
        public static double Division(double num1, double num2)
        {
            double quotient = num1/num2;
            return quotient;
        }

        /// <summary>
        /// Adds 2 values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns>Sum of the two values</returns>
        public static double Addition(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// Adds 2 values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns>Difference of the two values</returns>
        public static double Subtraction(double num1, double num2)
        {
            double difference = num1 - num2;
            return difference;
        }

        /// <summary>
        /// Adds 2 values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns>Product of the two values</returns>
        public static double Multiplication(double num1, double num2)
        {
            double product = num1 * num2;
            return product;
        }
    }
}
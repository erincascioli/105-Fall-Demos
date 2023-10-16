
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
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("ADDITION -------------------");

                    // Ask user for first value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the first number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number1 = double.Parse(Console.ReadLine());

                    // Ask user for second value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the second number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number2 = double.Parse(Console.ReadLine());

                    // Add the values and display sum
                    Console.ForegroundColor = ConsoleColor.White;
                    sum = number1 + number2;
                    Console.WriteLine("  The sum is " + sum);
                    break;

                case "SUBTRACTION":
                    // Display headline to introduce user to mathematical process
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("SUBTRACTION -------------------");

                    // Ask user for first value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the first number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number1 = double.Parse(Console.ReadLine());

                    // Ask user for second value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the second number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number2 = double.Parse(Console.ReadLine());

                    // Add the values and display difference
                    Console.ForegroundColor = ConsoleColor.White;
                    difference = number1 - number2;
                    Console.WriteLine("  The difference is " + difference);
                    break;

                case "MULTIPLY":
                    // Display headline to introduce user to mathematical process
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("MULTIPLICATION -------------------");

                    // Ask user for first value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the first number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number1 = double.Parse(Console.ReadLine());

                    // Ask user for second value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the second number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number2 = double.Parse(Console.ReadLine());

                    // Add the values and display difference
                    Console.ForegroundColor = ConsoleColor.White;
                    product = number1 * number2;
                    Console.WriteLine("  The product is " + product);
                    break;

                case "DIVISION":
                    // Display headline to introduce user to mathematical process
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("DIVISION -------------------");

                    // Ask user for first value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the first number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number1 = double.Parse(Console.ReadLine());

                    // Ask user for second value
                    // Parse to a double
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  Enter the second number: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    number2 = double.Parse(Console.ReadLine());

                    // Add the values and display difference
                    Console.ForegroundColor = ConsoleColor.White;
                    quotient = number1 / number2;
                    Console.WriteLine("  The quotient is " + quotient);
                    break;

                default:
                    Console.WriteLine(userMenuChoice + " is not a valid option.");
                    break;
            }
        }
    }
}
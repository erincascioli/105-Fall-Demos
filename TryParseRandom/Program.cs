
// Erin Cascioli
// 10/23/23
// Demo: Random Numbers and TryParse

namespace TryParseRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Random
            // ----------------------------------------------------------------
            Console.WriteLine("*** Random practice *************************");

            // Must create a single Random OBJECT (will get into this more on Friday!)
            // Ideally: only have 1 Random object in your project
            Random myRNG = new Random();

            // And then call methods on that Random object.
            // Next() --> Any value from 0 through int.MaxValue
            // Next(int) --> Any value from 0 through the inputted integer (exclusive)
            // Next(int, int) --> Any value from first integer (inclusive) through second integer (exclusive)

            // Generate a single random value from 0 through int.MaxValue:
            int singleRandomValue = myRNG.Next();
            Console.WriteLine("Single random value: " + singleRandomValue);

            // Generate 10 random values from 0 through int.MaxValue:
            Console.WriteLine("\nTen values using Next()");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.Next());
            }

            // Generate 10 random values from 0 through 10:
            Console.WriteLine("\nTen values using Next(11)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.Next(11));
            }

            // Generate 10 random values from 20 through 30:
            Console.WriteLine("\nTen values using Next(20, 31)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.Next(20, 31));
            }

            // Generate 10 random values from 102 through 382:
            Console.WriteLine("\nTen values using Next(102, 383)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.Next(102, 383));
            }

            // Generate 10 random doubles:
            Console.WriteLine("\nTen values using NextDouble()");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.NextDouble());
            }

            // Generate ten random values between 8.0 and 13.9999999999999999:
            Console.WriteLine("\nTen values using Next(8, 14) and NextDouble()");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myRNG.NextDouble() + myRNG.Next(8, 14));
            }

            // Generate ten random values between 8.0 and 14.0 (exclusive):
            Console.WriteLine("\nTen values using Next(8, 14) and NextDouble()");
            for (int i = 0; i < 10; i++)
            {
                double randomValue = myRNG.NextDouble() + myRNG.Next(8, 14);
                Console.WriteLine(Math.Round(randomValue, 2));
            }


            // ----------------------------------------------------------------
            // TryParse
            // ----------------------------------------------------------------
            Console.WriteLine("\n*** TryParse practice *************************");

            // Out variable must already exist before calling TryParse
            int result = -1;

            Console.WriteLine("Enter a number between 1 and 10: ");
            string userInput = Console.ReadLine();

            // Call TryParse, saving the returned value in a bool variable
            //   and saving the parse result into an out variable.
            bool success = int.TryParse(userInput, out result);

            // Parse was either unsuccessful or number was out of range.
            // Prompt user for re-entry and validate data.
            while (!success || (result <= 0 || result > 10) )
            {
                Console.WriteLine("Number was invalid. Re-enter the number: ");
                userInput = Console.ReadLine();
                success = int.TryParse(userInput, out result);
            }

            // We eventually get here ONLY when the parse is successful AND
            //   the number is in range.
            Console.WriteLine("You have successfully entered a value between 1 and 10!");
            Console.WriteLine($"Your data is {result}.");
        }
    }
}
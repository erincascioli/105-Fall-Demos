
// Erin Cascioli
// 9/29/23
// Demo: Switch and String Formatting


namespace SwitchStringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Switch Statements
            // ----------------------------------------------------------------
            // Switch statements allow for a comparison of discrete values that
            //   will conditionally run a block of code.

            // *********************************
            // ** Switch with discrete values **
            // *********************************

            // Ask user for a chosen color.
            Console.Write("Which option? BLUE, RED, or PURPLE? ");
            string userInput = Console.ReadLine()!.Trim();

            // Determine which color the user chose.
            // Then change console text to a matching color.
            switch(userInput.ToUpper())
            {
                case "BLUE":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "RED":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "PURPLE":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            // ***********************************
            // ** Switch with a range of values **
            // ***********************************

            // Ask user for a number greater than 5.
            Console.Write("Great! Now give me a number greater than 5. ");
            int userNumber = int.Parse(Console.ReadLine()!);

            // Display whether their number fell in the prompted range.
            switch (userNumber)
            {
                case > 5:
                    Console.WriteLine("Thanks! Your value was in the correct range!");
                    break;

                default:
                    Console.WriteLine("Your value was too low. :(");
                    break;
            }


            // ----------------------------------------------------------------
            // String Formatting 3 ways
            // ----------------------------------------------------------------

            // ****************
            // ** ToString() **
            // ****************

            // The ToString method returns a new string, where the data is formatted using 
            //   specifiers like "C2" or "N5"
            double teaPrice = 2.29;
            string sentence = "Yusef's tea cost " + teaPrice.ToString("C2") + " this morning.";
            Console.WriteLine(sentence);

            double gasPrice = 1293.899;
            string gasPriceFormatted = gasPrice.ToString("C2");
            Console.WriteLine("Gas cost " + gasPriceFormatted);

            // *********************
            // ** String.Format() **
            // *********************

            // String.Format returns a string with variable information inserted and
            //   formatted with specifiers like C2 or P3.
            sentence = String.Format(
                "Yusef's tea cost {0:C2} this morning.",
                teaPrice); 
            Console.WriteLine(sentence);

            double testGrade = 0.95;
            sentence = String.Format(
                "Bobby received {0:P0} on the first test in the class.",
                testGrade); 
            Console.WriteLine(sentence);

            // ***********************
            // ** C.WL() formatting **
            // ***********************

            // Can also directly format a string inline in a C.WL statement.
            // Syntax is similar to String.Format with formatting specifiers.
            Console.WriteLine(
                "Bobby received {0:P0} on the first test in the class.",
                testGrade);

            // Can combine the ToString method with string interpolation.
            Console.WriteLine(
                $"Bobby received {testGrade.ToString("P0")} on the first test in the class.");
        }
    }
}
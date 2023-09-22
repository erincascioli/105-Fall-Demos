
// Erin Cascioli
// 9/22/23
// Demo: If Statements (Conditionals)

namespace IfStatements_Sec3
{
    internal class Program
    {
        static void Main(string[] args)
        {            

            // Boolean variables must be compatible for expression evaluation
            bool isFallNow = true;
            bool amHungry = false;
            int largeNum = 2000;
            int smallNum = 9;

            Console.WriteLine("Are these the same? " + (isFallNow == amHungry));
            Console.WriteLine("Are these the same? " + (largeNum == smallNum));
            //Console.WriteLine("Are these the same? " + (isFallNow > largeNum));


            // PSEUDOCODE
            // Greet user. Ask: Does user wants to change text color? YES or NO
            // Gather input.
            // IF Yes:
            //      IF they typed red
            //          Change the text color to red.
            //      ELSE IF they typed yellow
            //          Change the text color to yellow.
            //      ELSE IF they typed magenta
            //          Change the text color to magenta.
            //      ELSE
            //          Change the text color to blue.
            // IF NO:
            //      Confirm they are not changing the colors.


            // Greet user.
            // Ask if they want to change the text color?
            // Gather input.
            Console.WriteLine("Hi. Do you want to change the colors?");
            Console.Write("Your choices are: YES or NO. ");
            string userChoice = Console.ReadLine().Trim();

            // IF YES:
            if(userChoice.ToUpper() == "YES")
            {
                Console.WriteLine("Hi. What is your favorite color?");
                Console.Write("Your choices are: RED or YELLOW or MAGENTA. ");
                string userColor = Console.ReadLine().Trim();

                if (userColor.ToUpper() == "RED")              // if ( userColor.ToLower() == "red" )
                {
                    Console.WriteLine("Here's some red for you!");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (userColor.ToUpper() == "YELLOW")        // if ( userColor.ToLower() == "yellow" )
                {
                    Console.WriteLine("Here's some yellow for you!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (userColor.ToUpper() == "MAGENTA")        // if ( userColor.ToLower() == "magenta" )
                {
                    Console.WriteLine("Here's some magenta for you!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.WriteLine("I don't recognize that input. The colors were red, yellow, or magenta.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            //IF NO --> ELSE:
            else
            {
                Console.WriteLine("I will keep your text white.");
            }

            // Goodbye!
            Console.WriteLine("Goodbye!");
        }
    }
}
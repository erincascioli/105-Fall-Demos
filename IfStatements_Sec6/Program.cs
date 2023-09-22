
// Erin Cascioli
// 9/22/23
// Demo: If Statements

namespace IfStatements_Sec6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Variable Block
            int largeNumber = 20000;
            double smallNumber = 20000;
            bool isSnowingYet = false;
            string food = "oatmeal";

            //Console.WriteLine(largeNumber > smallNumber);
            //Console.WriteLine(food > smallNumber);    // ERROR

            bool valuesAreEqual = (largeNumber == smallNumber);
            //Console.WriteLine(valuesAreEqual);

            // Conditional Statements
            //if (largeNumber == smallNumber)
            if (valuesAreEqual)
            {
                Console.WriteLine("The values are the same!");
            }

            Console.WriteLine("Thanks for playing.");
            */

            // DIRECTIONS:
            // MAKE A NEW PROJECT INSIDE YOUR LOCAL REPOSITORY --> DEMOS FOLDER
            // NAME IT WHATEVER MAKES SENSE TO YOU (WE ARE CHANGING CONSOLE TEXT COLORS)
            // ADD YOUR USUAL COMMENT BLOCK OF NAME/DATE/PURPOSE
            // THEN WE'LL GET TO GITHUB DESKTOP IN A MINUTE!

            /*
            // PSEUDOCODE --> Plan of what you want to do. Plan your program in comments!

            // PROGRAM PSEUDOCODE:
            // Prompt and ask the user for a color
            // Gather their input
            // IF the user chooses red:
            //     then change the text color to red.
            // Otherwise, don't change it. Do nothing.  <-- DONT CODE THIS.  

            // CODE:
            // Prompt and ask the user for a color.
            // Gather their input.
            Console.Write("Enter a color: ");
            string userColor = Console.ReadLine();

            // IF the user chooses red:
            //     then change the text color to red.
            if ( userColor == "red" )
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            // This statement is part of the Main method block of code and will execute always.
            Console.WriteLine(
                "Back to Main... this will execute regardless of what the user chose and will be in red!");
            */


            /*
            // PROGRAM PSEUDOCODE:
            // Prompt and ask the user for a color
            // Gather their input
            // IF the user chooses red:
            //     then change the text color to red.
            // ELSE (any other conceivable possibility)
            //     change the text color to blue

            // CODE:
            // Prompt and ask the user for a color.
            // Gather their input.
            Console.Write("Enter a color: ");
            string userColor = Console.ReadLine().Trim();

            // IF the user chooses red:
            //     then change the text color to red.
            if (userColor.ToLower() == "red")
            //if (userColor.ToUpper() == "RED")
            {
                string chosenColor = "red";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            // ELSE (any other conceivable possibility)
            //     change the text color to blue
            else
            {
                string chosenColor = "blue";
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine("You chose the color " + chosenColor);
            // This statement is part of the Main method block of code and will execute always.
            Console.WriteLine(
                "Back to Main... this will execute regardless of what the user chose and will be in red!");
            */




            // PROGRAM PSEUDOCODE:
            // Prompt the user for changing the text color - Yes or No?
            // Gather their input
            // IF user says yes:
            //     Ask the user which color - red or anything else?
            //    Gather input
            //    IF red:
            //        Change text color to red
            //    ELSE:
            //        Change to blue
            // IF user says no:
            //    Confirm they are not changing color.

            Console.Write("Do you want to change the text color? YES or NO: ");
            string userChoice = Console.ReadLine().Trim();

            if(userChoice.ToLower() == "yes")                    // YES
            {
                Console.Write("Enter a color: ");
                string userColor = Console.ReadLine().Trim();

                // IF the user chooses red:
                //     then change the text color to red.
                if (userColor.ToLower() == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                // ELSE (any other conceivable possibility)
                //     change the text color to blue
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            else                                                // NO
            {
                Console.WriteLine("The text color will not be changed.");
            }


        }
    }
}
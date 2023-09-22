
// Erin Cascioli
// 9/22/23
// Demo: If Statements

namespace IfStatements_Sec6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boolean Values and Boolean Expressions
            // ----------------------------------------------------------------
            // Boolean Values and Boolean Expressions
            // ----------------------------------------------------------------

            // Variable Block
            int largeNumber = 210;
            double smallNumber = 200;
            bool isSnowingYet = false;
            string food = "oatmeal";

            // Will print True or False to the console window, depending on the evaluation
            Console.WriteLine("Is largeNumber bigger than smallNumber? " + (largeNumber > smallNumber));

            // ** ERRORS with Boolean Expressions **
            // Cannot assign the value of an incompatible Boolean expression into a Boolean variable.
            // Food (string) cannot be compared to a number (double)
            //Console.WriteLine(food > smallNumber);    // ERROR

            // ** Boolean variables and Boolean Expressions **
            // Boolean variables can be assigned the result of a Boolean expression evaluation.
            bool valuesAreEqual = (largeNumber == smallNumber);
            Console.WriteLine("Are the values equal? " + valuesAreEqual);

            // Pause the program!
            Console.WriteLine("\n--- Press any key to continue! ---");
            Console.ReadLine();
            #endregion


            #region Conditional Statements
            // ----------------------------------------------------------------
            // Conditional Statements
            // ----------------------------------------------------------------

            // ** Conditions **
            // Can use a Boolean expression OR a variable value as the condition!
            // Code inside this if statement will ONLY execute if it evaluates to true.
            if (largeNumber == smallNumber)         // OR you can say: if (valuesAreEqual)
            {
                Console.WriteLine("The values are the same!");
            }

            // ** Multiple IF statements **
            // Multiple IF statements in a series are seen as different conditionals.
            // They are not a "set" or "connected."

            // Ask user for number from 1 to 10.
            Console.Write("Enter a whole number from 1 to 10: ");
            int userNumber = int.Parse(Console.ReadLine());

            // Did they guess your number?
            if(userNumber > 5)
            {
                Console.WriteLine($"{userNumber} is too big!");
            }
            if (userNumber < 5)
            {
                Console.WriteLine($"{userNumber} is too small!");
            }
            if(userNumber == 5)
            {
                Console.WriteLine($"{userNumber} is just right!");
            }

            // Pause the program!
            Console.WriteLine("\n--- Press any key to continue! ---");
            Console.ReadLine();
            #endregion


            #region Pseudocode
            // ----------------------------------------------------------------
            // Pseudocode
            // ----------------------------------------------------------------

            // Pseudocode is a plan of what you want your program to do.
            // Plan your program out in comments!

            // ** THIS PROGRAM's PSEUDOCODE: **
            // Prompt the user for changing the text color - Yes or No?
            // Gather their input
            // IF user says yes:
            //     Ask the user which color - red or anything else?
            //    Gather input
            //    IF red:
            //        Change text color to red
            //    ELSE:
            //        Change to blue
            // ELSE:
            //    Confirm they are not changing color.
            #endregion


            #region Code!
            // ** CODE: **

            // Prompt the user for changing text color.
            // Sanitize user's input.
            Console.Write("Do you want to change the text color? YES or NO: ");
            string userChoice = Console.ReadLine().Trim();

            // YES they want to change the text color.
            if(userChoice.ToLower() == "yes") 
            {
                // Prompt for a text color and gather input.
                Console.Write("Enter a color: ");
                string userColor = Console.ReadLine().Trim();

                // User chooses red: Change text color to red.
                if (userColor.ToLower() == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("All text is now RED!");
                }
                // User chooses anything else: Change text color to blue.
                else
                {
                    Console.Write("I don't recognize that color... All text is now ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("BLUE!");
                }
            }
            // User does not want to change text color.
            // (FYI: They could have said "no" or "nah" or "dfgsdz" because this is an else statement...)
            else
            {
                Console.WriteLine("The text color will not be changed.");
            }

            // Salutations!
            Console.WriteLine("Goodbye!");
            #endregion
        }
    }
}
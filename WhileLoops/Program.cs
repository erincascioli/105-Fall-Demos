
// Erin Cascioli
// 10/2/23
// Demo: While and Do-While Loops

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PSEUDOCODE:
            // Ask the user for 1-10
            // Gather their input
            // WHILE number is out of range
            //     Provide feedback
            //     Re-prompt for a new value


            // Prompt for value between 1 and 10
            // Get user's answer
            Console.Write("Number? ");
            int userNumber = int.Parse(Console.ReadLine());

            // As long as the user's value is invalid...
            while(userNumber <= 0 || userNumber >= 11)
            {
                // Give them feedback.
                Console.WriteLine("Invalid range!");

                // And re-prompt for a new number.
                Console.Write("Number? ");
                userNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Thanks for your number of {userNumber}!");





            // ----------------------------------------------------------------
            // WHILE LOOPS
            // ----------------------------------------------------------------
            // While loops allow for code to be repeated while (as long as)
            //   it meets the condition.
            // Conditions must evaluate to a Boolean value of true or false.
            // While loops check the condition at the BEGINNING of the loop -
            //   they may or may not ever run the code inside the while block.

            // ** 1 to 100, multiple lines **
            // Print the values 1 - 100 to the console window (while)



            // ** 1 to 100, same line with dash **
            // Print the values 1 - 100 to the console window on the same line
            // Use conditional statement to not print a dash after the last number (while)



            // ** Guess the password **
            // Guessing game with a word (while)



            // ** Nested loops **
            // Nested while loop:
            // 1. Want to play?
            // 2. Enter a value to guess.



            // ** Continue **
            // Print only even values from 20 - 30, using continue to skip over odds




            // ----------------------------------------------------------------
            // DO-WHILE LOOPS
            // ----------------------------------------------------------------
            // Do-While loops also allow for repetitive code as long as the condition
            //   evaluates to true.
            // Do-While loops check the condition at the END of the loop -
            //   code will always run at least once! 

            // ** 1 to 100, multiple lines **
            // Print the values 1 - 100 to the console window (do-while)



            // ** Guess the password **
            // Guessing game with a word (do-while)



            // Digit reverser


        }
    }
}
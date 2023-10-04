
// Erin Cascioli
// 10/2/23
// Demo: While and Do-While Loops

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // WHILE LOOPS
            // ----------------------------------------------------------------
            // While loops allow for code to be repeated while (as long as)
            //   it meets the condition.
            // Conditions must evaluate to a Boolean value of true or false.
            // While loops check the condition at the BEGINNING of the loop -
            //   they may or may not ever run the code inside the while block.


            // ----------------------------------------------------------------
            // ** Ask the user for a valid value **
            //
            // ** PSEUDOCODE: **
            // Ask the user for 1-10
            // Gather their input
            // WHILE number is out of range
            //     Provide feedback
            //     Re-prompt for a new value
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("ASKING USER FOR VALUE FROM 1 TO 10");
            Console.WriteLine("-----------------------------------------------");

            // Prompt for value between 1 and 10
            // Get user's answer
            Console.Write("Number between 1 and 10? ");
            int userNumber = int.Parse(Console.ReadLine());

            // As long as the user's value is invalid...
            while(userNumber <= 0 || userNumber >= 11)
            {
                // Give them feedback.
                Console.WriteLine("Invalid range!");

                // And re-prompt for a new number.
                Console.Write("Number between 1 and 10? ");
                userNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Thanks for your number of {userNumber}!");


            // ----------------------------------------------------------------
            // ** 1 to 20, multiple lines **
            // Print the values 1 - 20 to the console window (while)
            //
            // ** PSEUDOCODE: **
            // Start LCV at 1
            // WHILE number is not yet 20
            //     Print the number
            //     Increase it by 1 until it reaches 20
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("PRINT ALL VALUES 1 - 20 SEPARATE LINES");
            Console.WriteLine("-----------------------------------------------");

            int counter = 1;
            while(counter <= 20)
            {
                Console.WriteLine(counter);
                counter++;
            }


            // ----------------------------------------------------------------
            // ** 1 to 20, same line with dash **
            // Print the values 1 - 20 to the console window on the same line
            // Use conditional statement to not print a dash after the last number (while)
            //
            // ** PSEUDOCODE: **
            // Start LCV at 1
            // WHILE number is not yet 20
            //     Print the number
            //     Add a dash if it's not the end number of 20
            //     Increase the number by 1
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("PRINT ALL VALUES 1 - 20 SAME LINES");
            Console.WriteLine("-----------------------------------------------");

            counter = 1;
            while (counter <= 20)
            {
                // Always print the number.
                Console.Write(counter);

                // Only print the dash if it's not the last number (20).
                if (counter < 20)
                {
                    Console.Write("-");
                }

                // Increase the value being printed.
                counter++;
            }

            // Start the next code on the next line
            Console.WriteLine();


            // ----------------------------------------------------------------
            // ** Guess the password **
            // Guessing game with a word (while)
            //
            // ** PSEUDOCODE: **
            // Start LCV password as "abc1234"
            // Prompt user for password. Gather input.
            // WHILE they guessed incorrectly...
            //     Re-prompt user for password with "invalid" message.
            //     Gather new input.
            //     IF the guess correct...
            //         Notify of correct guess!
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("GUESS THE PASSWORD (abc1234)");
            Console.WriteLine("-----------------------------------------------");

            string password = "abc1234";

            // Prompt user to enter a value
            Console.Write("Enter the password? ");
            string userGuess = Console.ReadLine();

            // As long as the user has not guessed the password...
            while(userGuess != password)
            {
                // Give feedback and re-gather their guess
                Console.Write("Incorrect guess. Try again. Enter the password? ");
                userGuess = Console.ReadLine();

                // Did they guess it? Give feedback!
                if(userGuess == password)
                {
                    Console.WriteLine("Yay! You guessed it!");
                }    
            }


            // ----------------------------------------------------------------
            // ** Nested loops **
            // Nested while loop:
            // 1. Want to play?
            // 2. Enter a value to guess.
            //
            // ** PSEUDOCODE: **
            // Start LCV password as "new password"
            // Does user want to play the game?
            // As long as they keep choosing "YES"...
            //     Prompt user for password. Gather input.
            //     WHILE they guessed incorrectly...
            //         Re-prompt user for password with "invalid" message.
            //         Gather new input.
            //         IF the guess correct...
            //             Notify of correct guess!
            //     Do they want to play again? Gather input.
            //
            // ** CODE: **

            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("GUESS THE PASSWORD (new password)");
            Console.WriteLine("-----------------------------------------------");

            // Vars needed for this situation:
            string userChoice = "";
            userGuess = "";
            password = "new password";

            Console.Write("Do you want to play my guessing game? Enter Y or N: ");
            userChoice = Console.ReadLine().Trim().ToUpper();

            // Keep going if user wants to play the game
            while(userChoice == "Y")
            {
                // Prompt user to enter a password
                Console.Write("Enter the password: ");
                userGuess = Console.ReadLine();

                // As long as the user has not guessed the password...
                while (userGuess != password)
                {
                    // Give feedback and re-gather their guess
                    Console.Write("Incorrect guess. Try again. Enter the password. ");
                    userGuess = Console.ReadLine();
                }

                // Did they guess it? Give feedback!
                // The only way to get this far in the game is if the user entered a correct value
                //   and breaks out of the inner "invalid word" loop!
                if (userGuess == password)
                {
                    Console.WriteLine("Yay! You guessed it!");
                }

                // Ask if they want to play again
                Console.Write("Do you want to play my game AGAIN? Enter Y or N: ");
                userChoice = Console.ReadLine().Trim().ToUpper();
            }


            // ----------------------------------------------------------------
            // ** Continue **
            // Print only even values from 20 - 30, using continue to skip over odds
            //
            // ** PSEUDOCODE: **
            // Start LCV at 20
            // WHILE the number hasn't reached 30 yet...
            //     Increase by 1 (ensures LCV changes and stops infinite loop)
            //     Is it an odd value? Skip over this iteration.
            //     Print the value.
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("PRINT EVENS, SKIP ODDS WITH CONTINUE");
            Console.WriteLine("-----------------------------------------------");

            counter = 19;
            while (counter <= 30)
            {
                counter++;

                if (counter % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(counter);
            }




            // ----------------------------------------------------------------
            // DO-WHILE LOOPS
            // ----------------------------------------------------------------
            // Do-While loops also allow for repetitive code as long as the condition
            //   evaluates to true.
            // Do-While loops check the condition at the END of the loop -
            //   code will always run at least once! 

            // ----------------------------------------------------------------
            // ** 1 to 20, multiple lines **
            // Print the values 1 - 100 to the console window (do-while)
            //
            // ** PSEUDOCODE: **
            // Start LCV at 1
            // Do this:
            //     Print value and increase it by 1.
            // WHILE the value hasn't reached 20 yet...
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("1 - 20 WITH A DO-WHILE");
            Console.WriteLine("-----------------------------------------------");

            counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter <= 20);


            // ----------------------------------------------------------------
            // ** 1 to 20, SAME line **
            // Print the values 1 - 20 to the console window (do-while)
            //
            // ** PSEUDOCODE: **
            // Start LCV at 1
            // Do this:
            //     Print value.
            //     Does it need a dash? 
            //     Increase it by 1.
            // WHILE the value hasn't reached 20 yet...
            //
            // ** CODE: **
            // Headline for the code:
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("1 - 20 WITH A DO-WHILE, SAME LINE");
            Console.WriteLine("-----------------------------------------------");
            counter = 1;
            do
            {
                Console.Write(counter);
                if (counter < 20)
                {
                    Console.Write("-");
                }
                counter++;
            }
            while (counter <= 20);
        }
    }
}
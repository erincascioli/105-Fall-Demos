
// Erin Cascioli
// 9/30/23
// Completed PE 12 Code

/*
Students may compare their PE 12 (Switch and String Formatting) code against this solution.

It is NOT required that students resubmit any broken code.
This code is to be used for studying purposes only, and to guide students in fixing their 
code and/or better understanding their code.

The teaching team will NOT check off this exercise in class.
As long as your PE 12 was submitted on time, you will earn full credit for the PE.
*/

namespace SwitchStringFormatting_PE_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variables needed for program:
            // ----------------------------------------------------------------

            // Want to play?
            string readyToPlay;

            // Used in all 3 questions
            string question;
            string userInput;
            string response;

            // Question 1
            const double dollarAmount = 5;
            string formattedDollarInQuestion;
            double userDollarAmount;

            // Question 2
            int input1;
            int input2;
            int input3;

            // ----------------------------------------------------------------
            // PSEUDOCODE
            // ----------------------------------------------------------------

            // PSEUDOCODE for Question 1:
            // Format question with C2 and String.Format
            // Gather response
            // Format their inputted value as C2.
            // IF they are correct
            //     use formatted input value in response
            // ELSE
            //     use formatted input value in response


            // PSEUDOCODE for Question 2:
            // Print question for user and gather their 3 answers into 3 separate variables
            // Determine correctness:
            // IF they are ascending (1 is bigger than 2 which is bigger than 3)
            //     Correct!
            // ELSE IF they are in reverse order
            //     Backwards!
            // ELSE
            //     No pattern!


            // PSEUDOCODE for Question 3:
            // Print question for user
            // Gather their answer
            // SWITCH to check their answer:
            //     a, c, and d --> Incorrect (empty cases)
            //     b           --> Correct
            //     default     --> Invalid

            // ----------------------------------------------------------------
            // CODE
            // ----------------------------------------------------------------

            // Prompt for initial input - do they want to play?
            Console.Write("Ready to play my game? Enter \'yes\' for yes, or \'no\' for no: ");
            readyToPlay = Console.ReadLine().Trim().ToLower();

            // YES!
            if (readyToPlay == "yes" ||
                readyToPlay == "y")
            {
                Console.WriteLine("-------------------------------------------");

                // *****************************
                // ******** Question #1 ********
                // *****************************

                // Ask user the question, formatted using ToString() and String.Format() methods.
                formattedDollarInQuestion = dollarAmount.ToString("C2");
                question = String.Format(
                    "What is {0} * 7? $",
                    formattedDollarInQuestion);
                Console.Write(question);

                // Gather user's response and format as C2
                userDollarAmount = double.Parse(Console.ReadLine());
                formattedDollarInQuestion = userDollarAmount.ToString("C2");

                // Determine correctness
                if (userDollarAmount == 35)
                {
                    response = String.Format(
                        "{0} is correct!",
                        formattedDollarInQuestion);
                    Console.WriteLine(response);
                }
                else
                {
                    response = String.Format(
                        "{0} is not quite right.",
                        formattedDollarInQuestion);
                    Console.WriteLine(response);
                }


                // *****************************
                // ******** Question #2 ********
                // *****************************

                // Print question for user and gather their 3 answers
                Console.WriteLine("\nEnter 3 whole numbers in *ascending* order:");
                Console.Write("1: ");
                input1 = int.Parse(Console.ReadLine());
                Console.Write("2: ");
                input2 = int.Parse(Console.ReadLine());
                Console.Write("3: ");
                input3 = int.Parse(Console.ReadLine());

                // Determine correctness
                if (input1 < input2 && input2 < input3)
                {
                    Console.WriteLine("That's correct!");
                }
                else if (input1 > input2 && input2 > input3)
                {
                    Console.WriteLine("That's backwards.");
                }
                else
                {
                    Console.WriteLine("I don't recognize a pattern in your answer.");
                }

                // *****************************
                // ******** Question #3 ********
                // *****************************

                // Provide question for user
                Console.WriteLine("\nSwitches are best for...");
                Console.WriteLine("\ta. Checking the status of a combination of variables");
                Console.WriteLine("\tb. Checking for different discrete values of the same variable");
                Console.WriteLine("\tc. Checking if a variable's value is within a certain range");
                Console.WriteLine("\td. All of the above");

                // Gather input. Check response with a switch. B is correct.
                userInput = Console.ReadLine().Trim().ToLower();

                switch (userInput)
                {
                    // A, C and D are incorrect
                    case "a":
                    case "c":
                    case "d":
                        Console.WriteLine(
                            "Sorry. That's incorrect. Switches are best for checking for " +
                            "different *discrete values* of the *same* variable.");
                        break;

                    // B is correct
                    case "b":
                        Console.WriteLine("Correct!");
                        break;
                    
                    // Catch-all for invalid input
                    default:
                        Console.WriteLine($"'{userInput}' is not an option!");
                        break;
                }
            }

            // NO!
            else if (readyToPlay == "no" ||
                     readyToPlay == "n")
            {
                Console.WriteLine("Okay, goodbye!");
            }

            // INVALID!
            else
            {
                Console.WriteLine("I do not recognize that response.");
            }
        }
    }
}
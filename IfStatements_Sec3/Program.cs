namespace IfStatements_Sec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Compatible
            bool isFallNow = true;
            bool amHungry = false;
            int largeNum = 2000;
            int smallNum = 9;

            Console.WriteLine("Are these the same? " + (isFallNow == amHungry));
            Console.WriteLine("Are these the same? " + (largeNum == smallNum));
            //Console.WriteLine("Are these the same? " + (isFallNow > largeNum));

            // New code block! A conditional, an if statement.
            if( amHungry )
            {
                Console.WriteLine("Eat!");
            }

            // Second if statement.
            // This is NOT CONNECTED to the first statement in any way!
            if ( largeNum > smallNum )
            {
                Console.WriteLine($"{largeNum} is greater than {smallNum}.");
            }
            */


            // Ask the user for their favorite color
            // Gather their input into a string variable
            // Based on their answer, change the console text!
            Console.Write("What is your favorite color? ");
            string userColor = Console.ReadLine().Trim();

            // If-Else statements
            // Did the user type in red? Change the text to red.
            if( userColor.ToUpper() == "RED" )
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
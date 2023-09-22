
// Erin Cascioli
// 9/22/23
// Demo: If Statements

namespace IfStatements_Sec6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Block
            int largeNumber = 20000;
            double smallNumber = 20000;
            bool isSnowingYet = false;
            string food = "oatmeal";

            //Console.WriteLine(largeNumber > smallNumber);
            //Console.WriteLine(food > smallNumber);    // ERROR

            //bool valuesAreEqual = (largeNumber == smallNumber);
            //Console.WriteLine(valuesAreEqual);

            // Conditional Statements
            if(largeNumber == smallNumber)
            {
                Console.WriteLine("The values are the same!");
            }

            Console.WriteLine("Thanks for playing.");

        }
    }
}
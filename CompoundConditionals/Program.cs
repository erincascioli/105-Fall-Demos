
// Erin Cascioli
// 9/27/23
// Demo: Compound Conditionals and Boolean Operators

namespace CompoundConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Compound Conditionals and Boolean Operators
            // ----------------------------------------------------------------
            // Boolean operators like && and || and ! evaluate Boolean expressions.
            // They can be used to combine multiple Boolean expressions into
            //   conditional statements, allowing for multiple conditions
            //   to be evaluated in a single conditional statement.

            // Without Boolean operators, every outcome thay required more than 
            //   one condition must be done with a nested conditional.

            // Here is a nested conditional that details when a person is able to drive
            //   in the states of New Jersey, Pennsylvania and Kentucky. 

            // When can you drive?
            // NJ --> 16 permit, 17 license
            // KY --> 15 permit, 16 license
            // PA --> 16 permit, 16 license
            string state = "PA";
            int age = 17;

            /*
            if(state == "NJ")
            {
                if(age == 16)
                {
                    Console.WriteLine("You can get a permit");
                }
                else if(age >= 17)
                {
                    Console.WriteLine("You can get a license");
                }
                else
                {
                    Console.WriteLine("You are ineligible");
                }
            }
            else if(state == "PA")
            {
                if (age >= 16)
                {
                    Console.WriteLine("You can get a permit or a license.");
                }
                else
                {
                    Console.WriteLine("You are ineligible");
                }
            }
            else if(state == "KY")
            {
                if (age == 15)
                {
                    Console.WriteLine("You can get a permit");
                }
                else if (age >= 16)
                {
                    Console.WriteLine("You can get a license");
                }
                else
                {
                    Console.WriteLine("You are ineligible");
                }
            }
            else
            {
                Console.WriteLine("I don't know the rules of your state.");
            }
            */


            // Here is a cleaner version of the nested conditional above.
            // It combines multiple conditions into single if statements, 
            //   allowing the coder to see exactly when an output is
            //   going to execute. 
            
            if ( (state == "NJ" && age == 16) ||        // NJ 16
                 (state == "KY" && age == 15))          // KY 15                 
            {
                Console.WriteLine("You can get a permit");
            }
            else if ((state == "NJ" && age >= 17) ||    // NJ 17+
                     (state == "KY" && age >= 16))      // KY 16+
            {
                Console.WriteLine("You can get a license");
            }
            else if (state == "PA" && age >= 16)        // PA 16+
            {
                Console.WriteLine("You can get a permit or a license.");
            }
            else if((state == "NJ" && age <= 15) ||     // NJ under 16
                    (state == "KY" && age <= 14) ||     // KY under 15
                    (state == "PA" && age <= 15))       // PA under 16
            {
                Console.WriteLine("You are ineligible");
            }
            else                                        // Any other state than NJ, KY or PA
            {
                Console.WriteLine("I don't know the rules of your state.");
            }
        }
    }
}
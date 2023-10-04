using System.Xml;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // CODE FROM LECTURE SLIDES
            // ----------------------------------------------------------------

            // ** FOR LOOP EXAMPLE **
            // Output is:
            // 0
            // 1
            // 2
            // 3
            // 4

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");


            // ** SCOPE EXAMPLE **
            // Output is:
            // 0
            // 1
            // 2
            // 3
            // 4
            // 5    <-- Ending value of i after the loop has completed execution

            // Declare variable here
            int inScope = 0;
            
            // Leave initialization section blank
            for (; inScope < 5; inScope++)
            {
                Console.WriteLine(inScope);
            }

            // Variable is still in scope!
            Console.WriteLine(inScope);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");



            // ----------------------------------------------------------------
            // OTHER FOR LOOPS
            // ----------------------------------------------------------------

            // Prints 0 through 9
            for (int i = 0; i <= 9; i++)            // or (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - \n");


            // Prints 9 through 0
            for (int i = 9; i >= 0; i--)            // or (int i = 9; i > -1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - \n");


            // Prints 1 through 10
            for (int i = 1; i <= 10; i++)           // or (int i = 0; i < 11; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - \n");


            // Prints 5 through 20
            for (int i = 5; i <= 20; i++)           // or (int i = 5; i < 21; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - \n");


            // Prints 10 through 90, skipping by 10
            for (int i = 10; i <= 90; i += 10)      // or (int i = 10; i < 91; i += 10)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - \n");


            // Starts at 100 and counts backwards by 10, including 0
            for (int i = 100; i >= 0; i -= 10)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - \n");



            // ----------------------------------------------------------------
            // NESTED FOR LOOPS (from slides)
            // ----------------------------------------------------------------

            // ** NESTED EXAMPLE 1 **
            // Output is:
            // 12
            // 34

            // Added to inside the nested loops
            int counter = 1;

            // Create 2 rows of numbers
            for (int r = 1; r <= 2; r++)
            {
                // Create 2 columns of numbers
                for (int c = 1; c <= 2; c++)
                {
                    // Print output at the associated spot
                    Console.Write(counter);
                    counter++;
                }
                // Break the line at the end of column 2
                Console.Write("\n");
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");



            // ** NESTED EXAMPLE 2 **
            // Output is:
            // Row 1: 1*2*3*4*5*6*7*8*9
            // Row 2: 1*2*3*4*5*6*7*8*9
            // Row 3: 1*2*3*4*5*6*7*8*9
            // Row 4: 1*2*3*4*5*6*7*8*9
            // Row 5: 1*2*3*4*5*6*7*8*9

            int numberRows = 5;
            int numberColumns = 9;

            // Create 5 rows of numbers
            for (int row = 1; row <= numberRows; row++)
            {
                // Prints row number
                Console.Write($"Row {row}: ");

                // Create 9 columns of numbers 
                for (int col = 1; col <= numberColumns; col++)
                {
                    // Print column number at the associated spot
                    Console.Write(col);

                    // Print asterisk between values
                    if (col < numberColumns)
                    {
                        Console.Write("*");
                    }
                }

                // Break the line at the end of columns
                Console.Write("\n");
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - \n");



            // ** NESTED EXAMPLE 3 **
            // Output is:
            // 0, 0
            // 0, 1
            // 0, 2
            // 0, 3
            // 1, 0
            // 1, 1
            // 1, 2
            // 1, 3
            // 2, 0
            // 2, 1
            // 2, 2
            // 2, 3

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.WriteLine(x + ", " + y);
                }
            }
        }
    }
}
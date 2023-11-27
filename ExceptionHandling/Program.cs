
// Erin Cascioli
// 11/27/23
// Demo: Exception Handling with Try/Catch blocks


namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Throwing and catching our own exceptions
            // ----------------------------------------------------------------

            // This class throws exceptions upon retrieving items at invalid indices.
            MyStuff stuffList = new MyStuff();

            // Adding will not throw an exception.  No need to be inside a try block.
            stuffList.AddNumber(5);
            stuffList.AddNumber(10);

            try
            {
                int returnedItem = stuffList.GetItem(0);   // METHOD THAT COULD THROW EXCEPTION
                Console.WriteLine(returnedItem);

                returnedItem = stuffList.GetItem(1);       // METHOD THAT COULD THROW EXCEPTION
                Console.WriteLine(returnedItem);

                returnedItem = stuffList.GetItem(2);       // METHOD THAT COULD THROW EXCEPTION
                Console.WriteLine(returnedItem);
            }
            catch(Exception error)
            {
                Console.WriteLine("Internal error: " + error.Message);
            }


            // ----------------------------------------------------------------
            // Handling C# thrown exceptions
            // ----------------------------------------------------------------

            // Add 2 numbers to a list
            List<int> numbers = null; 

            // Code in a try block prevents crashes.
            try
            {
                numbers.Add(10);
                numbers.Add(20);

                Console.WriteLine(numbers[5]);      // Exception thrown!
                numbers[7] = 29;                    // This line is skipped.
                numbers.Insert(10, 999);            // This line is skipped.
            }
            catch(NullReferenceException error)
            {
                Console.WriteLine("In the NullReference catch block!");

                // Alternate code: Initialize the numbers list and add data.
                numbers = new List<int>();
                numbers.Add(1);
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("In the ArgumentOutOfRangeException catch block!");

                // Alternate code: Let programmer know index was invalid.
                Console.WriteLine("Arguments are out of range! Valid indices are 0 through " + (numbers.Count - 1));
            }
            catch (Exception error)
            {
                Console.WriteLine("In the Exception catch block!");

                // Alternate code: Print the exception message. 
                // The alternate code is not always printing a message, but for now that's what we'll ask
                //   you to do to practice handling exceptions.
                Console.WriteLine("Error! "+ error.Message);
                Console.WriteLine("-------------");
                Console.WriteLine("Stack Trace: " + error.StackTrace);
            }

            // Code after a catch block will run as normal.
            Console.WriteLine("This will run after the catch!");
            Console.WriteLine("The rest of the program will continue onward.");
            Console.WriteLine("My list has " + numbers.Count + " item(s) in it!");            
        }
    }
}
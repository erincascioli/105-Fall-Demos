
// ***************************************************************************
// AUTHOR: ERIN CASCIOLI
//
// COMPLETED STATIC METHODS CODE FOR STUDENT USE
// USED AS A REFERENCE ONLY.
// ***************************************************************************


namespace Methods_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leave these variables here!
            // Setup variables necessary for testing all 6 methods
            bool success = false;
            int biggest = 0;
            string word = "";

            // **************************************************************************
            // Method #1 Testing                                                        *
            // **************************************************************************

            DisplayHeadline("Makes Ten");
                                    
            success = MakesTen(9, 10);
            Console.WriteLine(
                "Do the values 9 and 10 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(9, 9);
            Console.WriteLine(
                "Do the values 9 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(1, 9);
            Console.WriteLine(
                "Do the values 1 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);
            

            // **************************************************************************
            // Method #2 Testing                                                        *
            // **************************************************************************

            DisplayHeadline("Largest");
                        
            biggest = Largest(1, 2, 3);
            Console.WriteLine(
                "The largest value of 1, 2, and 3 is: {0}",
                           biggest);

            biggest = Largest(1, 3, 2);
            Console.WriteLine(
                "The largest value of 1, 3, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 2, 1);
            Console.WriteLine(
                "The largest value of 3, 2, and 1 is: {0}",
                           biggest);

            biggest = Largest(2, 1, 2);
            Console.WriteLine(
                "The largest value of 2, 1, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 3, 1);
            Console.WriteLine(
                "The largest value of 3, 3, and 1 is: {0}",
                           biggest);

            biggest = Largest(5, 5, 5);
            Console.WriteLine(
                "The largest value of 5, 5, and 5 is: {0}",
                           biggest);


            // **************************************************************************
            // Method #3 Testing                                                        *
            // **************************************************************************

            DisplayHeadline("Not String");
                        
            word = NotString("candy");
            Console.WriteLine("Your string 'candy' is now: {0}", word);

            word = NotString("x");
            Console.WriteLine("Your string 'x' is now: {0}", word);

            word = NotString("not bad");
            Console.WriteLine("Your string 'not bad' is now: {0}", word);

            word = NotString("nothing");
            Console.WriteLine("Your string 'nothing' is now: {0}", word);
            

            // **************************************************************************
            // Method #4 Testing                                                        *
            // **************************************************************************

            DisplayHeadline("Remove Index");
                        
            word = RemoveIndex("kitten", 1);
            Console.WriteLine("Your string 'kitten' removing 1 is now: {0}", word);

            word = RemoveIndex("kitten", 0);
            Console.WriteLine("Your string 'kitten' removing 0 is now: {0}", word);

            word = RemoveIndex("kitten", 5);
            Console.WriteLine("Your string 'kitten' removing 5 is now: {0}", word);

            word = RemoveIndex("kitten", 6);
            Console.WriteLine("Your string 'kitten' removing 6 is now: {0}", word);

            word = RemoveIndex("kitten", -1);
            Console.WriteLine("Your string 'kitten' removing -1 is now: {0}", word);

            word = RemoveIndex("a", 0);
            Console.WriteLine("Your string 'a' removing 0 is now: {0}", word);

            word = RemoveIndex("an", 0);
            Console.WriteLine("Your string 'an' removing 0 is now: {0}", word);
            

            // **************************************************************************
            // Method #5 Testing                                                        *
            // **************************************************************************

            DisplayHeadline("Print Letters");
                        
            PrintLetters("rabbit");
            PrintLetters("Hello");
            PrintLetters("");
            PrintLetters("Halloween!");


            #region Method Tests in Main - Method #6 Testing
            // **************************************************************************
            // Method #6 Testing                                                        *
            // TODO: Uncomment these method calls while testing your sixth method       *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Distance");

            /*
            double distance = Distance(0, 0, 0, 0);
            Console.WriteLine("The distance between (0, 0) and (0, 0) is: " + distance);

            distance = Distance(1, 0, 4, 4);
            Console.WriteLine("The distance between (1, 0) and (4, 4) is: " + distance);

            distance = Distance(10, 2, 3, 5);
            Console.WriteLine("The distance between (10, 2) and (3, 5) is: " + distance);
            */

            #endregion

        }   // End of Main - All static methods must be written AFTER this


        /// <summary>
        /// Prints a formatted headline in the console window.
        /// </summary>
        /// <param name="textToDisplay">The text that should be displayed. 
        /// Must not exceed 55 characters.</param>
        public static void DisplayHeadline(string textToDisplay)
        {
            // Determine the length of the string
            // Then create a string with all dashes of the appropriate length.
            string allDashes = "-------------------------";
            for(int i = 0; i < textToDisplay.Length; i++)
            {
                allDashes += "-";
            }

            // Print the resulting output
            Console.WriteLine();
            Console.WriteLine(allDashes);
            Console.WriteLine($"-------- {textToDisplay} method --------");
            Console.WriteLine(allDashes);
        }

     
        /// <summary>
        /// Given 2 integers, determine whether one of them is 10 or if their sum is 10.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <returns>True when one value is 10 or if the sum of values is 10. False otherwise.</returns>
        public static bool MakesTen(int number1, int number2)
        {
            if(number1 == 10 || number2 == 10)       // Either is 10
            {                 
                return true;
            }
            else if(number1 + number2 == 10)        // Sum is 10
            {
                return true;
            }

            return false;

            // OR remove the else condition with code:
            //if ((number1 == 10 || number2 == 10)  ||        // Either is 10
            //    (number1 + number2 == 10))                 // Sum is 10
            //{
            //    return true;
            //}

            //return false;
        }


        /// <summary>
        /// Returns the largest of three integers.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <param name="number3">Third value</param>
        /// <returns>Largest of the three integers.</returns>
        public static int Largest(int number1, int number2, int number3)
        {
            // Can break it down into smaller parts...
            int biggestValue = int.MinValue;                    // Start with a small number (unnecessary for this)
            biggestValue = Math.Max(number1, number2);          // Compare 1 & 2
            biggestValue = Math.Max(biggestValue, number3);     // Compare that largest val with 3
            return biggestValue;                                // Pass back the biggest value

            // Or in 1 line:
            // Compare 1 & 2, then compare the largest of those with 3.
            return Math.Max(Math.Max(number1, number2), number3);
        }


        /// <summary>
        /// Given a string, return a new string where "not " is added to the front.
        /// Strings that begin with "not" are unchanged.
        /// </summary>
        /// <param name="phrase">String to analyze.</param>
        /// <returns>String with "not " appended to the front, 
        /// or original string if it contains "not" as the first 3 characters</returns>
        public static string NotString(string phrase)
        {
            // Is the string smaller than 3 characters? It can't possible start with "not"
            // Are the first 3 characters of the string anything other than "not"?
            if(phrase.Length < 3 || phrase.Substring(0, 3).ToLower() != "not")
            {
                return "not " + phrase;
            }

            // This code will only ever be reached if the string has enough letters and also
            //   starts with "not".
            return phrase;
        }


        /// <summary>
        /// Given a non-empty string and an int n, return a new string where the
        //  character at index n has been removed.
        /// </summary>
        /// <param name="phrase">String that will have characters removed.</param>
        /// <param name="index">A valid index of a char in the original string</param>
        /// <returns>Returns removed string or "Index is out of range" upon invalid index. 
        /// Returns "<empty> if string will be empty after removal. </returns>
        public static string RemoveIndex(string phrase, int index)
        {
            // Index out of range.
            if(index < 0 || index >= phrase.Length)
            {
                return "Index out of range";
            }
            // String is currently empty or will be empty after a single character removal.
            else if(phrase.Length <= 1)
            {
                return "<empty>";
            }

            // We'll only ever get here if the above 2 return statements are not hit!
            string removedString = phrase.Remove(index, 1);
            return removedString;

            // OR return phrase.Remove(index, 1);
        }


        /// <summary>
        /// Prints each letter in a string, separated by a dash. 
        /// NO dash after the last letter.
        /// </summary>
        /// <param name="phrase">String to be printed</param>
        public static void PrintLetters(string phrase)
        {
            // CAN DO THIS:
            for(int i = 0; i < phrase.Length; i++)
            {
                // No dash if last character
                if(i == phrase.Length - 1)
                {
                    Console.WriteLine(phrase[i]);
                }
                // Dash for all other characters
                else
                {
                    Console.Write(phrase[i] + "-");
                }
            }

            // OR THIS:
            for (int i = 0; i < phrase.Length; i++)
            {
                if (i < phrase.Length - 1)
                {
                    Console.Write(phrase[i] + "-");
                }
                else
                {
                    Console.Write(phrase[i]);
                }
            }

            // OR THIS:
            for (int i = 0; i < phrase.Length - 1; i++)
            {
                Console.Write(phrase[i] + "-");
            }
            // ONLY if the string has more than 1 character
            if (phrase.Length > 0)
            {
                Console.WriteLine(phrase[phrase.Length - 1]);
            }

            // OR THIS:
            for (int i = 0; i < phrase.Length; i++)
            {
                // Print the character no matter what
                Console.Write(phrase[i]);

                // Is it not the end? Print a dash.
                if (i != phrase.Length - 1)
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }


        #region Static Methods to Write #6 - Distance
        // **************************************************************************
        // TODO: Write method #6, Distance                                          *
        //                                                                          *
        // Method #6: Distance                                                      *
        // Accepts 4 values (floating-point numbers are ok)                         *
        // Calculates the distance between (x1, y1) and (x2, y2)                    *
        //                                                                          *
        // Method Identifier:   Distance                                            *
        // Parameters:          Receive 4 integers                                  *
        // Return:              Double of the calculated distance between the 2     *
        //                      points in space.                                    *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   Distance(0, 0, 0, 0)  → 0                                              *
        //   Distance(1, 0, 4, 4)  → 5                                              *
        //   Distance(10, 2, 3, 5) → 7.615773105863909                              *
        // **************************************************************************

        /*  W R I T E    T H E    M E T H O D    H E R E */


        #endregion

    }       // End of Program class - All static methods must be written BEFORE this
}           // End of Namespace
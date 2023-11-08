
// Erin Cascioli
// 10/20/23
// Demo: Method Overloading and Array Algorithms


namespace ArrayAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call overloaded methods
            int answer1 = Add(2, 6, 5, 3);
            int answer2 = Add(5, 9, 2);
            double answer3 = Add(4.5, 9.0);

            // Calling array algorithm methods
            int[] numbers = { 2, 5, 9, 12, 200 };
            Console.WriteLine("The array values are:");
            PrintArray(numbers);

            int smallest = FindMinValue(numbers);
            Console.WriteLine($"Smallest value is {smallest}");

            int largest = FindMaxValue(numbers);
            Console.WriteLine($"Largest value is {largest}");

            int range = CalculateRange(numbers);
            Console.WriteLine($"Range is {range}");
        }

        #region Overloaded Methods
        // Overloaded Methods

        /// <summary>
        /// Performs addition upon integer values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns>Sum of two integers</returns>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        /// <summary>
        /// Performs addition upon double values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <returns>Sum of two doubles</returns>
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }


        /// <summary>
        /// Performs addition upon integer values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <param name="num3">Third value</param>
        /// <returns>Sum of three integers</returns>
        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        /// <summary>
        /// Performs addition upon integer values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <param name="num3">Third value</param>
        /// <param name="num4">Fourth value</param>
        /// <returns>Sum of four integers</returns>
        public static int Add(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }


        /// <summary>
        /// Performs addition upon integer values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <param name="num3">Third value</param>
        /// <param name="num4">Fourth value</param>
        /// <param name="num5">Fifth value</param>
        /// <returns>Sum of five integers</returns>
        public static int Add
            (int num1, int num2, int num3, int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;
        }


        /// <summary>
        /// Performs addition upon integer values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <param name="num3">Third value</param>
        /// <param name="num4">Fourth value</param>
        /// <param name="num5">Fifth value</param>
        /// <param name="num6">Sixth value</param>
        /// <returns>Sum of six integers</returns>
        public static int Add(
            int num1, 
            int num2, 
            int num3, 
            int num4, 
            int num5, 
            int num6)
        {
            return num1 + num2 + num3 + num4 + num5 + num6;
        }


        /// <summary>
        /// Performs addition upon integer values.
        /// </summary>
        /// <param name="num1">First value</param>
        /// <param name="num2">Second value</param>
        /// <param name="num3">Third value</param>
        /// <param name="num4">Fourth value</param>
        /// <param name="num5">Fifth value</param>
        /// <param name="num6">Sixth value</param>
        /// <param name="num7">Seventh value</param>
        /// <returns>Sum of seven integers</returns>
        public static int Add(
            int num1, int num2, int num3, int num4, int num5, int num6, int num7)
        {
            return num1 + num2 + num3 + num4+ num5 + num6 + num7;
        }
        #endregion


        #region Array Methods

        /// <summary>
        /// Prints the values of an integer array
        /// </summary>
        /// <param name="numberArray">Array of integers</param>
        public static void PrintArray(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("  " + numberArray[i]);
            }
        }
        #endregion


        #region Array Algorithm Methods

        /// <summary>
        /// Finds the range of an integer array
        /// </summary>
        /// <param name="numberArray">Array of integers</param>
        /// <returns>Range (difference between smallest and largest values)</returns>
        public static int CalculateRange(int[] numberArray)
        {
            // Call FindMaxValue and FindMinValue methods, passing this array
            //   parameter to them.
            int largest = FindMaxValue(numberArray);
            int smallest = FindMinValue(numberArray);

            // Calculate and return the range
            return largest - smallest;
        }

        
        /// <summary>
        /// Finds the largest value in an array
        /// </summary>
        /// <param name="numberArray">Array of integers</param>
        /// <returns>Largest element's data</returns>
        public static int FindMaxValue(int[] numberArray)
        {
            // Students brainstorm ideas for writing this method!

            // Start with a really small value
            int largest = int.MinValue;

            // Look at each element in the array
            for(int i = 0; i < numberArray.Length; i++)
            {
                // Is this element bigger than what I think the biggest thus far is?  
                if (numberArray[i] > largest)
                {
                    // Overwrite the largest to be this bigger number!
                    largest = numberArray[i];
                }
            }

            return largest;
        }


        /// <summary>
        /// Finds the smallest value in an array
        /// </summary>
        /// <param name="numberArray">Array of integers</param>
        /// <returns>Smallest element's data</returns>
        public static int FindMinValue(int[] numberArray)
        {
            // Start with a really big value
            int smallest = int.MaxValue;

            // Look at each element in the array
            for (int i = 0; i < numberArray.Length; i++)
            {
                // Is this element smaller than what I think the smallest thus far is?  
                if (numberArray[i] < smallest)
                {
                    // Overwrite the smallest to be this smaller number!
                    smallest = numberArray[i];
                }
            }

            return smallest;
        }

        #endregion

    }
}
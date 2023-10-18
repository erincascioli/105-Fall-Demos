namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Declare, initialize, and add data to an array
            // ----------------------------------------------------------------
            // Declare only (when you don't know the size)
            int[] numbers;

            // Initialize (once you know the size)
            numbers = new int[6];

            // Add data to the array
            numbers[0] = 42;
            numbers[1] = 785;
            numbers[2] = 15000;
            numbers[3] = 0;
            numbers[4] = 7;
            numbers[5] = 56;
            //numbers[127] = 1; // ERROR out of range

            // ----------------------------------------------------------------
            // Use arrays in static methods
            // ----------------------------------------------------------------
            // Call a static method to print the contents of an integer array
            PrintArray(numbers);

            // This tells us the type of data that is in this array.
            // Does NOT print the contents of the array.
            Console.WriteLine(numbers);

            // ----------------------------------------------------------------
            // Literal arrays
            // ----------------------------------------------------------------
            // Literal array
            int[] numbers2 = {6, 2, 9, 8, 1, 99, 272, 112, 4, 76, 2, 24, 6, 22, 56};
            PrintArray(numbers2);

            string[] names = {"Nikki", "Thor", "Parker"};
            PrintStringArray(names);
        }

        /// <summary>
        /// Prints all values in an integer array
        /// </summary>
        /// <param name="numArray">Array of integers</param>
        public static void PrintArray(int[] numArray)
        {
            Console.WriteLine("Here are the values of this array: ");
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("   - " + numArray[i]);
            }
        }

        /// <summary>
        /// Prints all values of a string array
        /// </summary>
        /// <param name="numArray">Array of strings</param>
        public static void PrintStringArray(string[] stringArray)
        {
            Console.WriteLine("Here are the values of this array: ");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("   - " + stringArray[i]);
            }
        }
    }
}

// Erin Cascioli
// 10/25/23
// Demo: Value and Reference types

namespace ValueReferenceTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Data for value types and reference types are found in different places in memory
            int a = 97;                     // ascii code for the character 'a'
            char b = 'b';                   // character 'b'
            string c = "c";                 // string "c"

            // Assigning a value type to another assigns a COPY of the data
            // Modifying one will NEVER modify the other.
            int aCopy = a;
            aCopy += 20;
            PrintValue(a);

            // Assigning a reference type to another assigns a REFERENCE to the data
            // Modifying one will ALWAYS modify the other.
            int[] numbers = new int[] {2, 4, 6};
            int[] numbers2 = numbers;
            numbers[0] = 100;
            numbers2[1] = 7;

            // Arrays are passed by reference - methods that modify/manipulate the 
            //   array's data modify the array passed into the method.
            ChangeArray(numbers);

            // Used for breakpoints only.
            Console.WriteLine();
        }


        /// <summary>
        /// Passing a value type to a method will not change the original value type.
        /// </summary>
        /// <param name="valueToPrint">Value that will be printed.</param>
        public static void PrintValue(int valueToPrint)
        {
            valueToPrint *= 2;
            Console.WriteLine(valueToPrint);
        }


        /// <summary>
        /// Passing a reference type to a method will change the original method.
        /// </summary>
        /// <param name="intArray">Array whose index 1 will change to 999. 
        /// Array must be size 1 or greater.</param>
        public static void ChangeArray(int[] intArray)
        {
            intArray[0] = 999;
        }
    }
}
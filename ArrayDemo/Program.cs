using System.Globalization;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers;

            numbers = new int[6];

            numbers[0] = 24;
            numbers[1] = 69;
            numbers[2] = 420;
            numbers[3] = 73;
            numbers[4] = 1_000_000;
            numbers[5] = 15;
            //numbers[7] = 6;
            //numbers[283] = 5;
            */

            int[] numbers = {24, 69, 420, 73, 1000000, 15};
            PrintArray(numbers);

            /*int[] tens = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                           110, 120, 130};*/

            int[] tens = new int[30];
            for(int i = 0; i < tens.Length; i++)
            {
                tens[i] = (i + 1) * 10;
            }

            //Console.WriteLine(tens);
            PrintArray(tens);

            string[] names = {"Lily", "Yusef", "Nelson"};
            PrintStringArray(names);

        }// MAIN


        public static void PrintArray(int[] numberArray)
        {
            for(int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }

        public static void PrintStringArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
    // PROGRAM
}
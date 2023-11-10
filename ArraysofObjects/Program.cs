using System.Diagnostics;

namespace ArraysofObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The Candy Bucket class handles organization and management of all
            //   Candy objects in this program
            CandyBucket myHalloweenBucket = new CandyBucket();

            // The PrintAllCandies method calls Print() on each of the Candy instances.
            myHalloweenBucket.PrintAllCandies();

            // See how many candies there are
            Console.WriteLine($"I have {myHalloweenBucket.NumberOfCandies} candies.");


            #region Other Code from In-Class Demo
            // ----------------------------------------------------------------
            // COMMON ERROR:
            // Make one object and them assign that SAME object to the array
            //   multiple times!
            // One object/instance -->
            // One memory address -->
            // The array holds the SAME memory address for all 14 elements
            // ----------------------------------------------------------------
           
            /*
            Candy[] bucket = new Candy[14];

            Candy myCandy = new Candy();
            for(int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = myCandy;
            }
            */


            // ----------------------------------------------------------------
            // "Right" Way:
            // Instantiate a new object inside the loop body
            // Multiple object/instances -->
            // Different memory addresses
            // ----------------------------------------------------------------
            
            /*
            Candy[] bucket = new Candy[15];

            // Instantiate 14 new candies into the array
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new Candy();
            }

            // Change one of them
            bucket[4].CandyType = "Milky Way";

            // Print their data
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i].Print();
            }
            */


            /*
            // Try object instantiation with a variable
            Candy firstCandy = new Candy();
            bucket[0] = firstCandy;

            // Try direct instantiation into the array
            bucket[1] = new Candy();

            // Change the type of the first candy
            firstCandy.CandyType = "M&Ms";
            //bucket[0].CandyType = "M&Ms";

            // Change the type of the second candy
            bucket[1].CandyType = "Kit Kat";
            */
            #endregion
        }
    }
}
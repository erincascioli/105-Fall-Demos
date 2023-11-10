using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysofObjects
{
    /// <summary>
    /// Contains multiple instances of Candy, stored in an array of Candy objects
    /// </summary>
    internal class CandyBucket
    {
        // --------------------------------------------------------------------
        // Fields
        private Candy[] bucket;


        // --------------------------------------------------------------------
        // Properties

        /// <summary>
        /// How many candies are in the bucket
        /// </summary>
        public int NumberOfCandies
        {
            get { return bucket.Length; }
        }


        // --------------------------------------------------------------------
        // Constructor
        public CandyBucket()
        {
            // Instantiate the array of Candy objects
            bucket = new Candy[10];

            // Place 10 of the same type of Candy in the bucket
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new Candy();
            }

            // Change a few here so they bucket is not full of the same candy
            bucket[1].CandyType = "Kit Kat";
            bucket[4].CandyType = "M&Ms";
            bucket[5].CandyType = "Milky Way";
            bucket[8].CandyType = "Smarties";
        }


        // --------------------------------------------------------------------
        // Methods

        /// <summary>
        /// Prints information about every Candy in the bucket
        /// </summary>
        public void PrintAllCandies()
        {
            // For loops are customizable in that they can start and stop at any index
            for(int i = 0; i < bucket.Length; i++)
            {
                bucket[i].Print();
            }

            // Foreach loops are also nice for iterating through EVERY element in the list.
            // Limitation of foreach loops: Will iterate through EVERY element EVERY time.
            // Cannot specify a custom range of indices.
            //foreach(Candy pieceOfCandy in bucket)
            //{
            //    pieceOfCandy.Print();
            //}
        }
    }
}

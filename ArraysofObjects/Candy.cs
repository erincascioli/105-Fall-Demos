using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysofObjects
{
    /// <summary>
    /// Represents a single fun-size piece of Candy
    /// </summary>
    internal class Candy
    {
        // --------------------------------------------------------------------
        // Field
        private string candyType;


        // --------------------------------------------------------------------
        // Property
        /// <summary>
        /// Allows access and modification of the type of candy
        /// </summary>
        public string CandyType
        {
            get { return candyType; }
            set { candyType = value; }
        }


        // --------------------------------------------------------------------
        // Default constructor only (for now)
        /// <summary>
        /// Constructs an instance of Candy.
        /// </summary>
        public Candy()
        {
            candyType = "Reeses Pieces";
        }


        // --------------------------------------------------------------------
        // Method
        /// <summary>
        /// Prints information about this candy
        /// </summary>
        public void Print()
        {
            Console.WriteLine(candyType);
        }

    }
}

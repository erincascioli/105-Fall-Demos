using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    /// <summary>
    /// Class that demonstrates internal exception throwing.
    /// </summary>
    internal class MyStuff
    {
        // Field of the class
        private List<int> stuff;


        // Property
        public int ListSize
        {
            get { return stuff.Count; }
        }


        /// <summary>
        /// Constructs a MyStuff object
        /// </summary>
        public MyStuff()
        {
            // Initialize the list.
            stuff = new List<int>();
        }


        /// <summary>
        /// Adds a valid integer to the list of stuff.
        /// </summary>
        /// <param name="number">Integer added to the list of stuff.</param>
        public void AddNumber(int number)
        {
            // Only add values to an initialized list.
            if(stuff != null)
            {
                stuff.Add(number);
            }
            // List was uninitialized? Initialize it, then add!
            else
            {
                stuff = new List<int>();
                stuff.Add(number);
            }
        }


        /// <summary>
        /// Returns the item at a specified index.
        /// </summary>
        /// <param name="index">Index of the item to retrieve</param>
        /// <returns>Item at the specified index.</returns>
        /// <exception cref="Exception">Exception thrown upon invalid index.</exception>
        public int GetItem(int index)
        {
            // Return the item at valid index
            if(index >= 0 && index < stuff.Count)
            {
                return stuff[index];
            }

            // Index negative? Throw exception.
            if(index < 0)
            {
                throw new Exception("The parameter index was negative.");
            }

            // Index too large? Throw exception.
            throw new Exception("The parameter index was too large.");
        }

    }
}

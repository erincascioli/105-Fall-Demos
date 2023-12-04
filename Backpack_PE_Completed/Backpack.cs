using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backpack_PE
{
    /// <summary>
    /// Backpack class represents the items that a game's NPC is carrying.
    /// </summary>
    internal class Backpack
    {
        private string owner;
        private List<string> items;
        private Random generator;

        public string Owner
        {
            get { return owner; }
        }


        /// <summary>
        /// Constructs a Backpack object.
        /// </summary>
        /// <param name="owner">Name of the NPC carrying this pack.</param>
        public Backpack(string owner)
        {
            this.owner = owner;
            items = new List<string>();
            generator = new Random();
        }


        /// <summary>
        /// Adds an item to this pack.
        /// </summary>
        /// <param name="item">Item to add</param>
        public void AddToPack(string item)
        {
            if (item != null)
            {
                items.Add(item);
                Console.WriteLine(
                    "The item {0} was added to {1}'s backpack.", 
                    item, 
                    owner);
            }
        }


        /// <summary>
        /// Retrieves an item from a specific index.
        /// </summary>
        /// <param name="index">Index of the item to retrieve</param>
        /// <returns>String, the item in the pack.</returns>
        /// <exception cref="Exception">Error occurs when backpack is empty or invalid index.</exception>
        public string GetItemInSlot(int index)
        {
            // Invalid index throws exception
            if (index < 0 || index >= items.Count)
            {
                string errorMessage = "";

                if (items.Count == 0)
                {
                    errorMessage = "Backpack is empty.";
                }
                else
                {
                    // Formulate error message based on size of the items list
                    errorMessage = String.Format(
                    "The specified index {0} is out of the range {1} to {2}.",
                    index,
                    0,
                    items.Count - 1);
                }

                throw new Exception(errorMessage);
            }

            // The only way you'll get here is if the index is in range...

            // Save the string in the list
            string itemFromBackpack = items[index];

            // Remove it from the list
            items.RemoveAt(index);

            // Return the removed item
            return itemFromBackpack;
        }


        /// <summary>
        /// Retrieves an item from a randomly-generated valid index.
        /// </summary>
        /// <returns>String, item at that index</returns>
        /// <exception cref="Exception">Error occurs when backpack is empty</exception>
        public string GetRandomItem()
        {
            // Empty list throws exception
            if (items.Count == 0)
            {
                string errorMessage = String.Format("Cannot return item from {0}'s empty backpack.", owner);
                throw new Exception(errorMessage);
            }

            // Generate random index
            int randomIndex = generator.Next(0, items.Count);

            // Save the string in the list
            string itemFromBackpack = items[randomIndex];

            // Remove it from the list
            items.RemoveAt(randomIndex);

            // Return the removed item
            return itemFromBackpack;
        }


        /// <summary>
        /// Prints all contents to the console window.
        /// </summary>
        public void PrintPackContents()
        {
            // Introduce printed output
            Console.WriteLine("{0}'s backpack contents:", owner);

            // Empty backpack triggers special output
            if (items.Count == 0)
            {
                Console.WriteLine("Backpack is empty!");
            }

            // Full backpack prints each item to console.
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("- " + items[i]);
            }
        }


        // EXTRA!
        public List<string> DumpPack()
        {
            // Get rid of all items in the list

            // Can I return a reference to this class's items list? 
            // No, because after I clear the list, nothing will be in there

            // Need to make a copy of the list's contents, then return that.
            List<string> copyOfContents = new List<string>();
            foreach (string item in items)
            {
                copyOfContents.Add(item);
            }

            // Clear this backpack
            items.Clear();

            // Return the new, copied list.
            return copyOfContents;
        }
    }
}

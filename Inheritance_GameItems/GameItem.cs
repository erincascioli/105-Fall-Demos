using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_GameItems
{
    /// <summary>
    /// Parent class to Weapon and Potion.
    /// </summary>
    internal class GameItem
    {
        // Fields that are common to ALL children
        protected string name;
        protected double purchaseCost;
        protected double sellCost;
        protected double weight;


        /// <summary>
        /// Constructor for a GameItem.
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="purchase">Purchase price of this item</param>
        /// <param name="sell">Selling cost of the item</param>
        /// <param name="weight">How much the item weighs</param>
        public GameItem(string name, double purchase, double sell, double weight)
        {
            this.name = name;
            this.purchaseCost = purchase;
            this.sellCost = sell;
            this.weight = weight;
        }


        // Methods that are common to ALL children
        // Pick up the item, Buy, Check for incumbered
        // Drop, Despawn Spawn, Sell 
        // Use  (this looks different for all children!)

        public void Purchase()
        {
            Console.WriteLine($"This item costs {purchaseCost}.");
        }

        public void Sell()
        {
            Console.WriteLine($"You will receive {sellCost} when you sell the item.");
        }

    }
}

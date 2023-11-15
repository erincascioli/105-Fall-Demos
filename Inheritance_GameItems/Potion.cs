using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_GameItems
{
    /// <summary>
    /// Child class of GameItem.
    /// Represents a liquid potion that can be drank.
    /// </summary>
    internal class Potion : GameItem
    {
        // Fields that are unique to Potion        
        private string effect;
        private int uses;

        
        /// <summary>
        /// Constructor for a Potion object, where all Potions are named "potion"
        /// and have the same default information for costs and weight.
        /// </summary>
        /// <param name="effect">The effect upon the player</param>
        /// <param name="uses">How many doses exist</param>
        public Potion(string effect, int uses) : 
            base("potion", 25, 2, 0.5)
        {
            this.effect = effect;
            this.uses = uses;
        }


        /// <summary>
        /// Constructor for a Potion object, where all Potions have custom names,
        /// and a unique purchase cost. Sell cost and weight are default.
        /// </summary>
        /// <param name="name">Name of the potion</param>
        /// <param name="purchaseCost">How much the potion costs when purchasing</param>
        /// <param name="effect">The effect upon the player</param>
        /// <param name="uses">How many doses exist</param>
        public Potion(string name, double purchaseCost, string effect, int uses) : 
            base(name, purchaseCost, 2, 0.5)
        {
            this.effect = effect;
            this.uses = uses;
        }


        /// <summary>
        /// Use the potion by drinking a dose.
        /// </summary>
        public void Drink()
        {
            // As long as enough doses are left, drink the potion!
            if(uses > 0)
            {
                Console.WriteLine($"You drink the {name} potion, which has the effect of {effect}.");
                uses--;
            }
            else
            {
                Console.WriteLine("Not enough potion left to use it.");
            }
        }

    }
}

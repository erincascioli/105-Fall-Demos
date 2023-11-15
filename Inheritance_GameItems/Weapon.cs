using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_GameItems
{
    /// <summary>
    /// Child class of GameItem.
    /// Represents any weapon.
    /// </summary>
    internal class Weapon : GameItem
    {
        // Fields that are unique to Weapon
        private double damageDealt;
        private double durability;
        private double maxDurability;
        private string durabilityCategory;
        private double deteriorationPercentage;
        private bool isRepairable;


        /// <summary>
        /// Constructor for the Weapon class
        /// </summary>
        /// <param name="damage">Amount of damage this weapon deals (when at full durability)</param>
        /// <param name="maxDurability">Full durability</param>
        /// <param name="durabilityCategory">Is this weapon fragile, sturdy, or hardy?</param>
        /// <param name="name">Name of the weapon</param>
        /// <param name="purchaseCost">Cost to purchase</param>
        /// <param name="sellCost">Cost to sell</param>
        /// <param name="weight">Weight of the item</param>
        public Weapon(
            double damage, double maxDurability, string durabilityCategory, bool repairable,    // Unique to Weapon
            string name, double purchaseCost, double sellCost, double weight) :                 // Sent to parent
            base(name, purchaseCost, sellCost, weight)                                          // Call parent constructor
        {
            this.damageDealt = damage;
            this.maxDurability = maxDurability;
            this.durability = maxDurability;
            this.durabilityCategory = durabilityCategory;
            this.isRepairable = repairable;

            // Determing fragility based on the durability category
            switch(this.durabilityCategory)
            {
                case "fragile":
                    deteriorationPercentage = 0.6;
                    break;
                case "sturdy":
                    deteriorationPercentage = 0.2;
                    break;
                case "hardy":
                    deteriorationPercentage = 0.05;
                    break;
            }
        }


        /// <summary>
        /// Repair the weapon back to its maximum value.
        /// </summary>
        public void Repair()
        {
            if(isRepairable)
            {
                durability = maxDurability;
                Console.WriteLine("Weapon is repaired!");
            }
            else
            {
                Console.WriteLine("Weapon cannot be repaired!");
            }
        }


        /// <summary>
        /// Attack with this weapon
        /// </summary>
        /// <returns>Hit points with which to damage other players</returns>
        public double Attack()
        {
            double attackDamage = 0;

            // Damage is reduced to 50% when durability is between 1% and 50%
            // The weapon takes a durability hit
            if (durability <= (maxDurability * 0.5))
            {
                attackDamage = damageDealt * 0.5;
            }
            // Full damage when > 50% durability
            else if(durability > 0)
            {
                attackDamage = damageDealt;
            }

            // Weapon is reduced by the deterioration percentage of its max durability
            durability -= maxDurability * deteriorationPercentage;

            Console.WriteLine($"{name} attacks for {attackDamage}!");
            return attackDamage;
        }
    }
}

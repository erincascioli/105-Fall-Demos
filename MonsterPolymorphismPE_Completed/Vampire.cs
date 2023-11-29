using System;

namespace Sec5_MonsterDemo
{

    /// <summary>
    /// Vampire inherits from the Monster class.
    /// Represents a vampire who subsists on blood.
    /// Vampires can die of hunger if they don't eat every ten days.
    /// </summary>

    class Vampire : Monster
    {
        private double hungerRate;
        private string currentForm;

        public Vampire(string name, int age, double constitution) : 
            base(name, age, constitution, false)
        {
            // Uncomment this if you want to see the order that constructors run
            //Console.WriteLine("I am about to run the Vampire constructor.");

            // Fields unique to Vampire that are NOT in the Parent or Zombie
            this.hungerRate = constitution * 0.08;
            this.currentForm = "human";
        }


        /// <summary>
        /// Simulates the passing of time, where vampires slowly wither away
        /// from hunger and become incapacitated once they reach 0 constitution.
        /// </summary>
        public void TimePasses()
        {
            constitution -= hungerRate;
            constitution = Math.Round(constitution, 2);

            // Is the vampire getting desperate?
            if(constitution <= 60)
            {
                hungerRate += 2;
            }

            // Is the vampire out of energy?
            if (constitution <= 0)
            {
                this.isAnimated = false;
            }
        }

        /// <summary>
        /// Replenishes a vampire's constitution by drinking blood.
        /// </summary>
        /// <param name="victimName">Name of the victim that replenishes the vampire</param>
        public override void Eat(string victimName)
        {
            Console.WriteLine("{0} drinks the blood of {1} and feels restored.", name, victimName);
            constitution = 100;
        }


        /// <summary>
        /// Ability to change shape between a human and bat
        /// </summary>
        public void Shapeshift()
        {
            if (constitution > 10)
            {
                if (currentForm == "bat")
                {
                    currentForm = "human";
                }
                else
                {
                    currentForm = "bat";
                }
                Console.WriteLine("{0} shifts into {1} form.", name, currentForm);
            }
            else
            {
                Console.WriteLine("{0} no longer has the energy to swap forms.", name);
            }
        }

        /// <summary>
        /// Prints basic information about a Vampire.
        /// </summary>
        public override void Print()
        {
            // Base info from parent
            Console.WriteLine("Vampire information:");
            base.Print();

            // Then add on specific stuff about Vampires
            Console.WriteLine("Hunger rate: " + hungerRate);
            Console.WriteLine("Currently in {0} form.", currentForm);
        }

        public override string ToString()
        {
            string monsterInformation = base.ToString();
            string vampireInformation = "";

            if (constitution > 60)
            {
                vampireInformation = String.Format(
                    " {0}'s hunger is in check as they explore the night in {1} form.",
                    name, currentForm);
            }
            else if (constitution > 0)
            {
                vampireInformation = String.Format(
                    " {0} desperately wanders the night as a {1} in search of a midnight snack to curb hunger.",
                    name, currentForm);
            }
            else
            {
                vampireInformation = String.Format(
                    " {0}, lifeless from hunger, waits for a companion to bring a fresh treat before playing again.",
                    name);
            }

            return monsterInformation + vampireInformation;
        }
    }
}

using System;

namespace Sec5_MonsterDemo
{

    /// <summary>
    /// Zombie inherits from the Monster class.
    /// Represents an undead abomination who can die from decay over time.
    /// </summary>

    class Zombie : Monster
    {
        private double decayRate;


        public Zombie(string name, int age, double constitution) : 
            base(name, age, constitution, true)
        {
            // Uncomment this if you want to see the order that constructors run
            //Console.WriteLine("I am about to run the Zombie constructor.");

            // Field unique to Vampire that is NOT in the Parent or Zombie
            this.decayRate = 0.93;
        }
                
        /// <summary>
        /// Simulates the passing of time, where zombies slowly decay
        /// and "die" once they reach 0 constitution.
        /// </summary>
        public void TimePasses()
        {
            constitution *= decayRate;
            constitution = Math.Round(constitution, 2);

            if (constitution < 1)
            {
                this.isAnimated = false;
                Console.WriteLine("Zombie is 'dead'");
            }
        }

        /// <summary>
        /// Prints basic information about a Zombie.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("Zombie information:");
            base.Print();
            Console.WriteLine("Decay rate: " + decayRate);
        }

        public override string ToString()
        {
            string monsterInformation = base.ToString();
            string zombieInformation = "";

            if (!isAnimated)
            {
                zombieInformation = String.Format(
                    " As a zombie, {0} lost the ability to play in this game.",
                    name);
            }
            else
            {
                zombieInformation = String.Format(
                    " The zombie {0} still has time left in the game.", 
                    name);
            }

            return monsterInformation + zombieInformation;
        }

        /// <summary>
        /// Zombies have an unsatiable hunger for brains.
        /// </summary>
        /// <param name="victimName">Name of the zombie's victim</param>
        public override void Eat(string victimName)
        {
            Console.WriteLine("{0} chomps on the brains of {1} but is still hungry...", name, victimName);
        }
    }
}

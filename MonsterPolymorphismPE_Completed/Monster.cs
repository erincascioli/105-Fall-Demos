using System;
using System.Data;

namespace Sec5_MonsterDemo
{

    /// <summary>
    /// Parent Monster class.
    /// Has 2 children: Vampire and Zombie
    /// </summary>

    class Monster
    {
        protected string name;
        protected int age;
        protected double constitution;
        protected bool isAnimated;
        protected bool isUndead;

        public string Name
        {
            get { return name; }
        }

        public double Constitution
        {
            get { return constitution; }
        }

        public bool Animated
        {
            get { return isAnimated; }
        }

        public Monster()
        {
            this.name = "unknown";
            this.age = 0;
            this.isUndead = false;
            this.constitution = 0;
            this.isAnimated = false;
        }

        public Monster(string name, int age, double constitution, bool undead)
        {
            this.name = name;
            this.age = age;
            this.isUndead = undead;
            this.constitution = constitution;
            this.isAnimated = (constitution > 0);
        }

        /// <summary>
        /// Prints basic Monster statistics.
        /// Virtual means it can be overridden in a child class,
        /// though child classes are not forced to do so.
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Const: {0}", constitution);
            Console.WriteLine("Undead? {0}", isUndead);
            Console.WriteLine("Animated? {0}", isAnimated);
        }

        public virtual void Eat(string victim)
        {
            Console.WriteLine("{0} devours {1}.", name, victim);
        }

        public override string ToString()
        {
            string monsterRepresentation = "";

            // Monster still animated in the game
            if (isAnimated)
            {
                // Old monster's data
                if (age >= 60)
                {
                    monsterRepresentation = String.Format(
                        "{0} is old at the ripe age of {1}. ", 
                        name, 
                        age);
                }
                // Young monster's data
                else
                {
                    monsterRepresentation = String.Format(
                        "{0} is young at {1} years old. ", 
                        name, 
                        age);
                }

                // All monsters return their constitution
                monsterRepresentation += String.Format(
                    "They are existing with {0} constitution.",
                    constitution);
            }
            // Monster has "died"
            // Undead monsters cannot be revived. Others can.
            else
            {
                monsterRepresentation = String.Format(
                    "{0}'s constitution has fallen to zero. They are no longer animated",
                    name);

                if (isUndead)
                {
                    monsterRepresentation += " and cannot be revived.";
                }
                else
                {
                    monsterRepresentation += " but can be resuscitated.";
                }
            }

            return monsterRepresentation;
        }
    }
}

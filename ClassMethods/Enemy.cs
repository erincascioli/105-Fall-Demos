using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{

    /// <summary>
    /// Enemy class represents an NPC in the game.
    /// </summary>
    internal class Enemy
    {
        // --------------------------------------------------------------------
        // FIELDS
        // --------------------------------------------------------------------

        /// <summary>
        /// Name of this enemy, like "Bob"
        /// </summary>
        public string name;

        /// <summary>
        /// Starting health of the enemy
        /// </summary>
        public int health;

        /// <summary>
        /// X Position of the enemy (in a 2D game)
        /// </summary>
        public int xPosition;

        /// <summary>
        /// Y position of the enemy (in a 2D game)
        /// </summary>
        public int yPosition;

        /// <summary>
        /// Used to generate randon numbers within this class
        /// </summary>
        public Random generator;


        // --------------------------------------------------------------------
        // CONSTRUCTOR(S)
        // --------------------------------------------------------------------
        /// <summary>
        /// Constructs an Enemy object
        /// </summary>
        /// <param name="name">Enemy's name</param>
        /// <param name="health">Enemy's starting health value</param>
        /// <param name="xPosition">Horizontal 2D coordinate</param>
        /// <param name="yPosition">Vertical 2D coordinate</param>
        public Enemy(string name, int health, int xPosition, int yPosition)
        {
            // These values are coming from parameters!
            // Should always assign field = param; and not the other way around.
            this.name = name;
            this.health = health;
            this.xPosition = xPosition;
            this.yPosition = yPosition;

            // Instantiate the random object
            generator = new Random();
        }

        // *** Naming conventions for constructor identifiers ***
        // Your constructors could use a different naming convention, like the following:
        //
        // public Enemy(string enemyName, int enemyHealth)
        // {
        //     name = enemyName;
        //     health = enemyHealth;
        // }
        //      OR
        // public Enemy(string p_name, int p_health)
        // {
        //     name = p_name;
        //     health = p_health;
        // }

        // --------------------------------------------------------------------
        // METHODS
        // --------------------------------------------------------------------

        /// <summary>
        /// Prints information about this Enemy class.
        /// </summary>
        public void PrintEnemy()
        {
            // Access the fields of the class and print their information
            Console.WriteLine($"****** Information about {name}: *******");
            Console.WriteLine($"The enemy's name is {name}.");
            Console.WriteLine($"The enemy's health is {health}.");
            Console.WriteLine($"The enemy is at ({xPosition}, {yPosition}).");
            Console.WriteLine();
        }


        /// <summary>
        /// Damages the enemy's health by an amount of hit points
        /// </summary>
        /// <param name="hitPoints">Positive value</param>
        public void DamageEnemy(int hitPoints)
        {
            // Value must be positive so as to not heal the enemy.
            if(hitPoints > 0)
            {
                // Reduce the enemy's health by hit points:  health -= hitPoints
                health = health - hitPoints;
            }
        }


        /// <summary>
        /// Return a randomly-generated attack between 1 and 10.
        /// </summary>
        /// <returns>Random positive integer ranged 1 through 10.</returns>
        public int Attack()
        {
            int randomAttackValue = generator.Next(1, 11);
            return randomAttackValue;
        }


        /// <summary>
        /// Overloaded Attack allows custom range of random values.
        /// </summary>
        /// <param name="lowerRange">Lowest possible attack value</param>
        /// <param name="upperRange">Highest possible attack value</param>
        /// <returns>Random value between the lower and upper ranges</returns>
        public int Attack(int lowerRange, int upperRange)
        {
            int randomAttackValue = generator.Next(1, 11);
            return randomAttackValue;
        }


        /// <summary>
        /// Moves the enemy within the console window.
        /// </summary>
        /// <param name="xOffset">Number of units to the left or right, where negative values move left.</param>
        /// <param name="yOffset">Number of units to the top or bottom, where negative values move up.</param>
        public void Move(int xOffset, int yOffset)
        {
            xPosition += xOffset;
            yPosition += yOffset;
        }
    }
}

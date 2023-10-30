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
        // Fields come first

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

        // Constructors are listed next

        public Enemy(string name, int health, int xPosition, int yPosition)
        {
            // field = param;
            this.name = name;
            this.health = health;
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        // A different naming convention
        //public Enemy(string enemyName, int enemyHealth)
        //{
        //    name = enemyName;
        //    health = enemyHealth;
        //}

        // Methods listed last


        /// <summary>
        /// Prints information about this Enemy class.
        /// </summary>
        public void PrintEnemy()
        {
            // Access the fields of the class and print their information
            Console.WriteLine("The enemy's name is " + name);
            Console.WriteLine("The enemy's health is " + health);
            Console.WriteLine($"The enemy is at ({xPosition}, {yPosition})");
        }
    }
}


// Name
// Date
// Purpose

namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datatype identifier = new Constructor(params);
            Enemy bob = new Enemy("Bob", 25, 0, 100);
            bob.PrintEnemy();

            /*
            Console.WriteLine("The enemy's name is " + bob.name);
            Console.WriteLine("The enemy's health is " + bob.health);
            Console.WriteLine($"The enemy is at ({bob.xPosition}, {bob.yPosition})");
            */
        }
    }
}
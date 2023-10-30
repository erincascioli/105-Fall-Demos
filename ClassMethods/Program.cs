
// Name
// Date
// Purpose

namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new objects uses this syntax:
            // Datatype identifier = new Constructor(params);

            // ---------------------------------------------------------------
            // Object instantiation
            // ---------------------------------------------------------------

            // Create 2 new Enemy instances and print their values.
            Enemy bob = new Enemy("Bob", 25, 0, 100);
            bob.PrintEnemy();

            Enemy fred = new Enemy("Fred", 100, 300, 100);
            fred.PrintEnemy();

            // ---------------------------------------------------------------
            // Enemies attack each other
            // ---------------------------------------------------------------

            // Fred attacks Bob once.
            // Inspect Bob's values afterward.
            int fredAttack = fred.Attack();
            bob.DamageEnemy(fredAttack);
            Console.WriteLine("Fred attacked for " + fredAttack);
            bob.PrintEnemy();

            // Bob is MAD and attacks Fred 5 times.
            // Inspect Fred's values afterward.
            for(int i = 0; i < 5; i++)
            {
                int bobAttack = bob.Attack();
                fred.DamageEnemy(bobAttack);
                Console.WriteLine("Bob attacked for " + bobAttack);
            }
            fred.PrintEnemy();
        }
    }
}
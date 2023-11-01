
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
            PrintAttackInfo(fred.name, fredAttack, false);
            bob.PrintEnemy();

            // Bob is MAD and attacks Fred 5 times.
            // Inspect Fred's values afterward.
            for(int i = 0; i < 5; i++)
            {
                int bobAttack = bob.Attack();
                fred.DamageEnemy(bobAttack);
                PrintAttackInfo(bob.name, bobAttack, true);
            }
            fred.PrintEnemy();

            Console.WriteLine("Fred before move:");
            fred.PrintEnemy();
            fred.Move(50, -10);
            Console.WriteLine("Fred after move:");
            fred.PrintEnemy();
        } // END MAIN


        /// <summary>
        /// Print information about attacks between enemies
        /// </summary>
        /// <param name="attackerName">Name of the attacker</param>
        /// <param name="hitPoints">umber of hit points during the attack</param>
        /// <param name="rampage">Is the character raging?</param>
        public static void PrintAttackInfo(string attackerName, int hitPoints, bool rampage)
        {
            if(rampage)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("******* RAGE! *******");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******* Attack! *******");
            }

            Console.WriteLine($"{attackerName} attacked for {hitPoints} points.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }




    } // END PROGRAM
}
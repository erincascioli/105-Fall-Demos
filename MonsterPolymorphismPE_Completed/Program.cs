using System;
using System.Collections.Generic;

// Completed PE for Inheritance (Part One)
// This will evolve into the Polymorphism PE (Part Two)

namespace Sec5_MonsterDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test the parent Monster class
            Monster monsterA = new Monster("A", 75, 90, true);
            Monster monsterB = new Monster("B", 12, 73, false);
            Monster monsterC = new Monster("C", 46, 0, true);
            Monster monsterD = new Monster("D", 98, 0, false);

            monsterA.Print();
            monsterB.Eat("Princess Peach");

            Console.WriteLine();
            Console.WriteLine(monsterA.ToString());
            Console.WriteLine();
            Console.WriteLine(monsterB.ToString());
            Console.WriteLine();
            Console.WriteLine(monsterC);
            Console.WriteLine();
            Console.WriteLine(monsterD);

            // Test Zombie class
            Zombie zombieOne = new Zombie("Guts", 26, 100);
            Zombie zombieTwo = new Zombie("Munch", 39, 0);

            Console.WriteLine("----------------------------------");
            zombieOne.Print();
            Console.WriteLine();
            zombieTwo.Print();
            Console.WriteLine();

            zombieOne.Eat("Koopa Troopa");
            Console.WriteLine(zombieOne);
            Console.WriteLine(zombieTwo);

            // Test Vampire class
            Vampire vampireOne = new Vampire("Kalon", 1154, 53);
            Vampire vampireTwo = new Vampire("Calantha", 49, 20);
            Vampire vampireThree = new Vampire("Dragos", 344, 0);

            Console.WriteLine("----------------------------------");
            vampireOne.Print();
            Console.WriteLine();
            vampireTwo.Shapeshift();
            vampireTwo.Eat("Piranha Plant");
            Console.WriteLine();
            vampireThree.Shapeshift();
            Console.WriteLine();

            Console.WriteLine(vampireOne);
            Console.WriteLine(vampireTwo);
            Console.WriteLine(vampireThree);

            // List and Polymorph test!
            List<Monster> monsterList = new List<Monster>();
            monsterList.Add(monsterA);
            monsterList.Add(monsterB);
            monsterList.Add(monsterC);
            monsterList.Add(monsterD);
            monsterList.Add(zombieOne);
            monsterList.Add(zombieTwo);
            monsterList.Add(vampireOne);
            monsterList.Add(vampireTwo);
            monsterList.Add(vampireThree);

            foreach (Monster monster in monsterList)
            {
                monster.Print();

                if (monster is Vampire)
                {
                    Vampire monsterAsVampire = (Vampire)monster;
                    monsterAsVampire.Shapeshift();

                    ((Vampire)monster).Shapeshift();
                }

                if (monster is Zombie)
                {
                    Zombie monsterAsZombie = (Zombie)monster;
                    monsterAsZombie.Eat("Goomba");     
                }
            }
        }
    }
}

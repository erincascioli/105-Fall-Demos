
// Every new class you create contains these 5 using statements.
// Feel free to keep them there, or delete all but the first 2.

using System;                                   // Keep
using System.Collections.Generic;               // Keep
using System.Linq;                              // Don't need
using System.Text;                              // Don't need
using System.Threading.Tasks;                   // Don't need

namespace Classes_Fields_Constructors
{
    internal class Cat
    {
        // --------------------------------------------------------------------
        // Fields are listed first in the class
        // TODAY: use the public keyword
        // (Next week: we'll change this and discuss why)
        // --------------------------------------------------------------------
        public string name;
        public int age;
        public double brainCells;

        // --------------------------------------------------------------------
        // Constructors are written next in the class
        // Constructors are special methods that ensure all fields receive
        //   a value. 
        // Can have a default or parameterized or a combo of both.
        // BUT can only have 1 default and as many parameterized as needed - 
        //   no limit to the number of constructor overloads!
        // --------------------------------------------------------------------
        
        // DEFAULT constructor for the Cat class:
        public Cat()
        {
            // Assign every field a default value
            // All objects created with this default constructor are 13-year old
            // smart cats named Anna.
            name = "Anna";
            age = 13;
            brainCells = 294572.6;
        }


        // PARAMETERIZED constructors for the Cat class:
        public Cat(string name, int age, double brainCells)
        {
            // this. refers to the field in the class
            // and the identifier without this. refers to the local parameter...

            // "Assign THIS cat's name field the value found in the name parameter"
            this.name = name;

            // "Assign THIS cat's age field the value found in the age parameter"
            this.age = age;

            // "Assign THIS cat's brain cells field the value found in the brain cells parameter"
            this.brainCells = brainCells;
        }


        // --------------------------------------------------------------------
        // Other ways of naming your constructor parameters...
        // --------------------------------------------------------------------

        // Something similar to the field name --> Acceptable!
        /*
        public Cat(string catName, int catAge, double catCells)
        {
            name = catName;
            age = catAge;
            brainCells = catCells;
        }
        */

        // Nondescript identifiers  --> NOT acceptable!
        // Single letters           --> NOT acceptable!
        // Vowel reduction          --> NOT acceptable!
        // What does 'n' stand for? What values are required for 'a'?
        // What on earth does brnCls mean? Barn class? Brown close?
        /*
        public Cat(string n, int a, double b)           <-- Nope.
        {
            name = n;
            age = a;
            brainCells = b;
        }

        public Cat(string nm, int g, double brnCls)     <-- Never. 
        {
            name = nm;
            age = g;
            brainCells = brnCls;
        }

        public Cat(string a, int b, double c)           <-- No thank you. 
        {
            name = a;
            age = b;
            brainCells = c;
        }
        */
    }
}


// Erin Cascioli
// 10/27/23
// Demo: Beginning OOP with fields and constructors


namespace Classes_Fields_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Creating an instance of Random
            // ----------------------------------------------------------------
            // This creates an instance of the Random class
            // (Random is a valid DATATYPE in C#)
            Random generator = new Random();

            // ----------------------------------------------------------------
            // Initialize objects of a class
            // ----------------------------------------------------------------
            // Create 5 Cat objects using a combination of default and
            // parameterized constructor calls.
            Cat anna = new Cat();
            Cat dash = new Cat("Dash", 14, 5);
            Cat captain = new Cat("Captain Peanut Butter", 6, 3);
            Cat pippa = new Cat("Pippa", 9, 4);
            Cat carl = new Cat("Carl", 5, 20);


            // ----------------------------------------------------------------
            // Access public data in an object
            // ----------------------------------------------------------------
            // Access public data in objects using the dot operator and the field name
            Console.WriteLine("My cat's name is " + captain.name);
            Console.WriteLine("Anna is " + anna.age + " years old");

            if(pippa.brainCells < 10)
            {
                Console.WriteLine(pippa.name + " is straight up dumb (bless her heart)");
            }
        }
    }
}
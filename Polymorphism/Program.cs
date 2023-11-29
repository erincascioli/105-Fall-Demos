namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Shape();
            Circle myCircle = new Circle(3.49, ConsoleColor.Magenta);
            Square mySquare = new Square(5, ConsoleColor.DarkBlue);

            // ----------------------------------------------------------------
            // Polymorphism allows child class objects to be stored in a 
            //   parent class list/array/other data structure.
            // ----------------------------------------------------------------

            List<Shape> myShapes = new List<Shape>();
            myShapes.Add(myShape);
            myShapes.Add(myCircle);
            myShapes.Add(mySquare);

            foreach (Shape someShape in myShapes)
            {
                Console.WriteLine("Area: " + someShape.CalculateArea());
            }

            foreach (Shape someShape in myShapes)
            {
                someShape.PrintInformation();
            }


            // ----------------------------------------------------------------
            // ToString method returns a string representation of an object
            // ----------------------------------------------------------------

            foreach (Shape someShape in myShapes)
            {
                Console.WriteLine(someShape.ToString());

                // OR you can use this since ToString is automatically called, anyway. :)
                //Console.WriteLine(someShape);
            }


            // ----------------------------------------------------------------
            // Downcasting is required for unique method/property calls of
            //   child class objects.
            // ----------------------------------------------------------------

            // Only call Roll on Circles in the list.
            foreach (Shape someShape in myShapes)
            {
                // Check if the current object is a Circle
                if(someShape is Circle)
                {
                    // Downcast to a Circle object!
                    ((Circle)someShape).Roll();

                    // OR
                    //Circle thisObjAsCircle = (Circle)someShape;
                    //thisObjAsCircle.Roll();
                }
            }
        }
    }
}
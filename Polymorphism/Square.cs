using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Square : Shape
    {
        private double sideLength;


        /// <summary>
        /// Constructs a Square object
        /// </summary>
        /// <param name="sideLength">Length of one side</param>
        /// <param name="color">Text color of visual representations</param>
        public Square(double sideLength, ConsoleColor color) :
            base()
        {
            this.numberSides = 4;
            this.sideLength = sideLength;
            this.color = color;
            this.area = CalculateArea();
        }


        /// <summary>
        /// Calculates the area of this square based on its length of side.
        /// </summary>
        /// <returns>Area of this square</returns>
        public override double CalculateArea()
        {
            return sideLength * sideLength;
        }


        /// <summary>
        /// Displays Square information in the Console window. 
        /// </summary>
        public override void PrintInformation()
        {
            // Print method overrides the parent's to use its own unique version
            //   that works with a Circle object.
            Console.ForegroundColor = color;
            Console.WriteLine("I am a SQUARE!");
            Console.WriteLine("OOOOOO");
            Console.WriteLine("O    O");
            Console.WriteLine("O    O");
            Console.WriteLine("OOOOOO");
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Provides a string representation of the Square object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            // ToString method overrides the parent's to use its own unique version
            //   that works with a Square object.
            return $"I am a Square object with {numberSides} sides, a side length of {sideLength}, " +
                $"area {area} and in {color} color.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle : Shape
    {
        private double radius;


        /// <summary>
        /// Constructs a Circle object.
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        /// <param name="color">Text color of visual representations</param>
        public Circle(double radius, ConsoleColor color) :
            base()
        {
            // Overwrite the color value in the Shape class
            this.color = color;

            // Assign value to the unique radius field
            this.radius = radius;

            // Overwrite the area with this class's overridden CalcArea method
            //   so that the Circle has an accurate area.
            area = CalculateArea();
        }


        /// <summary>
        /// Calculates the area of this circle based on its radius.
        /// </summary>
        /// <returns>Area of this circle</returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }


        /// <summary>
        /// Displays Circle information in the Console window. 
        /// </summary>
        public override void PrintInformation()
        {
            // Print method overrides the parent's to use its own unique version
            //   that works with a Circle object.
            Console.ForegroundColor = color;
            Console.WriteLine("I am a CIRCLE!");
            Console.WriteLine("  OO ");
            Console.WriteLine("O    O");
            Console.WriteLine("O    O");
            Console.WriteLine("  OO ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Provides a string representation of the Circle object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            // ToString method overrides the parent's to use its own unique version
            //   that works with a Circle object.
            return $"I am a Circle object with area {area} and color {color}.";
        }


        /// <summary>
        /// Unique method to the Circle class.
        /// </summary>
        public void Roll()
        {
            Console.WriteLine("I am rolling.");
        }
    }
}

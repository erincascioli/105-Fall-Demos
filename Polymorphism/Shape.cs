using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Shape
    {
        protected double area;
        protected int numberSides;
        protected ConsoleColor color;

        public double Area
        {
            get { return area; }
        }


        /// <summary>
        /// Constructs a default Shape object
        /// </summary>
        public Shape()
        {
            area = 0;
            numberSides = 0;
            color = ConsoleColor.DarkGreen;
        }


        /// <summary>
        /// Calculates the area of a Shape.
        /// </summary>
        /// <returns>The area of the specified shape</returns>
        public virtual double CalculateArea()
        {
            return 0.0;
        }


        /// <summary>
        /// Prints information about the Shape.
        /// </summary>
        public virtual void PrintInformation()
        {
            Console.ForegroundColor = color;
            Console.WriteLine("I am a SHAPE!");
            Console.WriteLine("???");
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Provides a string representation of the Shape object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            string shapeInformation = $"I am a Shape object with area {area}";
            
            if (numberSides > 0)
            {
                shapeInformation += $", color {color}, and {numberSides} sides.";
            }
            else
            {
                shapeInformation += $" and no sides.";
            }

            return shapeInformation;
        }
    }
}

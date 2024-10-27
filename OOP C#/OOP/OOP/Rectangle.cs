using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {

        //declaration of field. Const has to be initialized during complite time.
        public const int NUmberOfCorners = 4;

        //readonly initialiazed during runtime
        public readonly string Color;


        public Rectangle(string color)
        {
            Color = color;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, Height: {Height}, Area: {Area}, Number of corners: {NUmberOfCorners}.");
        }

        public double Width { get; set; }

        public double Height { get; set; }
        //Computed property
        //If only getter - Read Only property
        public double Area
        {
            get { return Width * Height; }

        }


    }
}

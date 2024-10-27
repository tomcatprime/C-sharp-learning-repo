﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{

    //It's internal, which means that it can only be access from within the same assembly.
    internal class Car
    {
        //member variable
        //private hides the variable from other classes
        //Backing Field of the Model Property
        private string _model = "";
        private string _brand = "";

        private bool _isLuxury;

        //Property
        //with lambda expression
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if(IsLuxury)
                {
                    return _brand + "- Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            set {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }

        }


        public bool IsLuxury { get; set; }
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury= isLuxury;
            Console.WriteLine($"A car - Brand {Brand}, Model {Model} has been created.");

        }


        public void Drive()
        {
            Console.WriteLine($"I am a {Model} and I'm driving");
        }


    }
}

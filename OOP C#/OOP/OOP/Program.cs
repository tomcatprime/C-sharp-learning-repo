﻿using System.Threading.Channels;

namespace ClassesApp
{

    //Access modifier 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome in OOP C#!");

            Customer earl = new Customer("Earl");
            Console.WriteLine($"Name of customer is {earl.Name}");


            Customer frankTheTank = new Customer("FrankTheTank", "Mainstrret 1", "59894832923");

            //Default Customer with no Arguments given
            Customer myCustomer = new Customer();

            myCustomer.SetDetails("Frank", "Mainstreet2", "128347128124");

            Console.WriteLine($"My customer is {myCustomer.Name} and he lives in {myCustomer.Address}");

            Console.WriteLine($"Name is {earl.Name}, lives in {earl.Address}");

            Customer customer3 = new Customer();
            customer3.SetDetails("Denis", "One street1");
            customer3.Password = "dasdqw!#@211";

            Customer customer4 = new Customer("Szejker");
            Console.WriteLine($"Customer 4 name is {customer4.Name}, the address is default value {customer4.Address}");

            customer3.GetDetails();
            customer4.GetDetails();
            earl.GetDetails();

            Console.WriteLine($"Customer 3 ID is {customer3.Id}");

            Console.WriteLine("Please enter customer name");
            //overide default value of Name
            myCustomer.Name = Console.ReadLine();

            Console.WriteLine(myCustomer.Name);

            //Creating an Object/ an instance of the Class Car
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("i7", "BMW", true);

            Car myAudi = new Car("A4", "Audi", false);
            myAudi.Drive();

            Car myBMW = new Car("M5", "BMW", true);
            myBMW.Drive();


            Console.WriteLine("Please enter the Brand name");
            //Setting BRAND
            audi.Brand = Console.ReadLine();
            

            if (audi.Brand == "DEFAULTVALUE")
            {
                Console.WriteLine("No car brand available");
            }
            else
            {
                //Getting BRAND
                Console.WriteLine($"Car brand is  {audi.Brand}");
            }

            Console.WriteLine($"Brand is {audi.Brand}");
            Console.WriteLine($"Brand is {bmw.Brand}");

            //Accessing the public static variable numberOfCars of the Car class.
            Console.WriteLine($"Number of cars produced {Car.numberOfCars}");

            Console.WriteLine("======================================");

            Console.WriteLine(AddNum(15, 20));
            Console.WriteLine("======================================");
            Console.WriteLine("Using Name Parameter");
            Console.WriteLine(AddNum(firstNum: 16, secondNum: 20));

            Rectangle r1 = new Rectangle("Yellow");
            r1.Width = 5;
            r1.Height = 5;

            Console.WriteLine($"Area of r1 is {r1.Area}");

            Customer.DoSomeCustomerStuff();


            Console.WriteLine("=======================================");

            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();
            Console.ReadKey();


        }

        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}

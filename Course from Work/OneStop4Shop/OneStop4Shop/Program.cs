﻿// See https://aka.ms/new-console-template for more information

bool isFinished = false;

int[] productId = { 1001, 1002, 1003, 1004, 1005 };
string[] productName = { "Phone", "Headphones", "Apple", "Tablet", "TV"};

double[] price = {349.00, 25.99, 5.20, 450.00, 899.99};



while (!isFinished)
{
    Console.WriteLine("\n ---------Welcome to OneStop4Shop---------");
    Console.WriteLine(" 1. View products");
    Console.WriteLine(" 2. Generate bill");
    Console.WriteLine(" 3. Exit");
    Console.Write(" Please choose an option : ");
    try
    {

        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            //1. View products
            Console.Clear();
            Console.WriteLine("You have chosen to see all the products.");

            for (int i = 0; i < productId.Length; i++)
            {
                Console.WriteLine($"Product ID: {productId[i]} ---- Name: {productName[i]} --- Price: {price[i]}$");

            }
            Console.ReadKey();
        }
        else if (choice == 2)
        {
            //2. Generate bill
            Console.Clear();
            Console.WriteLine("You have chosen to generate the bill.");
        }
        else if (choice == 3)
        {
            //3. Exit
            Console.WriteLine("You have chosen to exit.");
            isFinished = true;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid menu option!");
        }
    }
Console.WriteLine("Thank you for shopping. See you soon...");
}


            
            int[,] array2D = {{1,2,3,3}, {4,5,6,3}, {7,8,9,3}};
            for (int i = 0; i < array2D.GetLength(0); i++)
            {   
                int sum = 0;
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    
                    sum += array2D[i,j];                
                }
                Console.WriteLine(sum);
            }

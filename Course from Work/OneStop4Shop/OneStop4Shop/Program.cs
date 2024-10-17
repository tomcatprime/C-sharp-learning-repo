// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

bool isFinished = false;

int[] productId = { 1001, 1002, 1003, 1004, 1005 };
string[] productName = { "Phone", "Headphones", "Apple", "Tablet", "TV"};

double[] price = {349.00, 25.99, 5.20, 450.00, 899.99};

char[] category = { 'S', 'B', 'S', 'E', 'A' };

char option;
float discount;
double billAmount;
string billID = "B1001";


while (!isFinished)
{
    Console.WriteLine("\n ---------Welcome to OneStop4Shop---------");
    Console.WriteLine(" 1. View products");
    Console.WriteLine(" 2. Generate bill");
    Console.WriteLine(" 3. Exit");
    Console.Write(" Please choose an option : ");
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
        //generate random number for the bill ID.
        Random rnd = new Random();
        
        int index = 0;
        double productPrice = 0;
        bool flag = false;
        billAmount = 0;

        while (true)
        {
            Console.WriteLine("Enter a product id: ");
            int id = int.Parse(Console.ReadLine());
            int billRandomNum1 = rnd.Next(1, 11);
            int billRandomNum2 = rnd.Next(1, 11);

            for (int i = 0; i < productId.Length; i++)
            {
                if (productId[i] == id)
                {
                    productPrice = price[i];
                    index = i;
                    flag = true;
                    break;
                }

            }



            if (flag == true)
            {
                switch (category[index])
                {
                    case 'S':
                        discount = 0.02f;
                        break;
                    case 'B':
                        discount = 0.05f;
                        break;
                    case 'E':
                        discount = 0.10f;
                        break;
                    case 'A':
                        discount = 0.20f;
                        break;
                    default:
                        discount = 0;
                        break;
                }
                billAmount += (productPrice - (productPrice * discount));
                Console.WriteLine(Math.Round(billAmount, 2));
            }
            // 2.iii. if product is not found
            else
            {
                Console.WriteLine();
                Console.WriteLine(" Products details not found!");
            }

            Console.WriteLine("Do you want to bill more products(Y/N)? ");
            option = Convert.ToChar(Console.ReadLine());    
            if (Char.ToLower(option) == 'y')
            {
                continue;
            }
            else if (Char.ToLower(option) == 'n')
            {
                Console.WriteLine($"Your bill id is {billID}");
            }
        }

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

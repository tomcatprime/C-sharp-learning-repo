// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the text Adventure Game!");
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();

Console.WriteLine($"Welcome {playerName}! Let's start adventure");
Console.WriteLine($"{playerName}, please choose your character's type ( Warrior, Wizard, Monk ).");
string characterType = Console.ReadLine();

int counter = 5;
Console.Clear();
Console.WriteLine("The story is starting in ....");
while (counter > 0)
{
    Console.WriteLine(counter);
    counter--;
    Thread.Sleep(500);
    
}

string logo =
    "{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}\n{} _____ _          _____ _                  _  _                     {}\n{}|_   _| |_  ___  |_   _| |_  _ _ ___ ___  | || |___ _ _ ___  ___ ___{}\n{}  | | | ' \\/ -_)   | | | ' \\| '_/ -_) -_) | __ / -_) '_/ _ \\/ -_|_-<{}\n{}  |_| |_||_\\___|   |_| |_||_|_| \\___\\___| |_||_\\___|_| \\___/\\___/__/{}\n{} ___ / _| | __| |__| |___ _ _(_)__ _                                {}\n{}/ _ \\  _| | _|| / _` / _ \\ '_| / _` |                               {}\n{}\\___/_|   |___|_\\__,_\\___/_| |_\\__,_|                               {}\n{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}";
Console.WriteLine(logo);


//Game part

Console.WriteLine($"You, {playerName}, the {characterType} find yourself at the edge of a dark forest.");

Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp");

String choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely enter the forest");
}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight.");
}


bool gameContinues = true;
while (gameContinues)
{
    Console.WriteLine(
        "You sense danger to the left but potential allies to the right. Which way will you go? (Left/Right)");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (Fight/Flee");
        string fightChoice = Console.ReadLine();
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beats!");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a treasure!");
                }
            }
            else
            {
                {
                    Console.WriteLine("The beast attacked you where you didn't expect it!");
                    gameContinues = false;
                }
            }
        }
        
    }
}


Console.WriteLine("Press any key to exit...");
Console.ReadKey();

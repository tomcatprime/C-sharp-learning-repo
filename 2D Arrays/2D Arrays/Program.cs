// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//declare 2D - TwoDimensional Arrays

//2D
int[,] arrays2DDEclaration = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]
arrays2DDEclaration = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine(arrays2DDEclaration[1,2]);

//Initialize 2D Array

int[,] array2DInitialized = { {1,2}, {3,4} }; // first row is 1,2, second row is 3,4
// [1] [2]
// [3] [4]

Console.WriteLine(array2DInitialized[0,0]);
Console.WriteLine(array2DInitialized[0,0]);

Console.WriteLine($"First Row:  [{array2DInitialized[0,0]}]  [{array2DInitialized[0,1]}]");
Console.WriteLine($"Second Row: [{array2DInitialized[1,0]}]  [{array2DInitialized[1,1]}]");

//overriding value 
array2DInitialized[0, 0] = 5;
array2DInitialized[0, 1] = 10;

Console.WriteLine($"First Row:  [{array2DInitialized[0,0]}]  [{array2DInitialized[0,1]}]");
Console.WriteLine($"Second Row: [{array2DInitialized[1,0]}]  [{array2DInitialized[1,1]}]");

//TicTacToe

string[,] arrayTicTacToe =  {{"[O]","[X]","[X]"}, {"[X]","[X]","[X]"}, {"[O]","[X]","[O]"}};

Console.WriteLine(arrayTicTacToe[0,0]);


//3D - ThreeDimensional Arrays

//declaration
int[,,] array3DDEclaration = new int[3, 3, 3];

//3Dimensions = 3 levels of brackets
//initialized 3 Dimension array
string[,,] array3DSimple =
{
    {
        {"000", "001"},
        {"010", "011"}
    },
    {
        {"100", "101"},
        {"110", "111"}
    }
};

Random numberRand = new Random();
//Example of 3D Array


Console.WriteLine(array3DSimple[1,1,0]);
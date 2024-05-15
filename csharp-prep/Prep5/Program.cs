using System;

class Program
{
    static void Main(string[] args)
    {
        ShowWelcomeMessage();
        string userName = GetUserName();
        int favoriteNumber = GetFavoriteNumber();
        int squaredNumber = CalculateSquare(favoriteNumber);
        ShowResult(userName, squaredNumber);
    }

    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int CalculateSquare(int number)
    {
        int square = number * number;
        return square;
    }

    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

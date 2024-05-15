using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> userInputs = new List<int>();
        int currentInput = -1;

        while (currentInput != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            currentInput = int.Parse(userResponse);

            if (currentInput != 0)
            {
                userInputs.Add(currentInput);
            }
        }

        int totalSum = 0;
        foreach (int number in userInputs)
        {
            totalSum += number;
        }
        Console.WriteLine($"The sum is: {totalSum}");

        float averageValue = ((float)totalSum) / userInputs.Count;
        Console.WriteLine($"The average is: {averageValue}");

        int maximumValue = userInputs[0];
        foreach (int number in userInputs)
        {
            if (number > maximumValue)
            {
                maximumValue = number;
            }
        }
        Console.WriteLine($"The max is: {maximumValue}");
    }
}

using System;
//Author: Mac Hartsell, Section 003
//Description: A program that simulates the rolling of dice and displays the results in a histogram.
class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Mac's Dice Throwing Simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        //getting user input for number of rolls
        int numRolls = int.Parse(Console.ReadLine());

        // reference to 2nd class
        DiceRoller diceRoller = new DiceRoller();

        //from 2nd class
        int[] results = diceRoller.Sim(numRolls);

        Console.WriteLine("\nRESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        //loop to calculate percentage
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            int percentage = results[iCount] * 100 / numRolls;
            Console.WriteLine($"{iCount}: {new string('*', percentage)}");
        }

        Console.WriteLine($"Total number of rolls = {numRolls}.");
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

class DiceRoller
{
    private Random random = new Random();

    public int[] Sim(int numRolls)
    { //results to be sent to first class
        int[] results = new int[13];
        // for loop to produce random numbers
        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}

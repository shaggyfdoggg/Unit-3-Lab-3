﻿Console.WriteLine("Welcome to the Grand Circus Casino!");
Console.WriteLine("How many sides should each die have?");
int input1 = int.Parse(Console.ReadLine().Trim().ToLower());

bool runProgram = true;
int roll = 1;

while (runProgram == true)
{
    int dice1 = RandomNumberGenerator(input1);
    int dice2 = RandomNumberGenerator(input1);

    Console.WriteLine($"Roll {roll}");
    Console.WriteLine($"You rolled a {dice1} and a {dice2}");
    Console.WriteLine(Combinations(dice1, dice2));
    Console.WriteLine(WinOrCraps(dice1, dice2));

    while (true)
    {

        Console.WriteLine("Roll again? (y/n)");
        string input2 = Console.ReadLine().Trim().ToLower();
        if (input2 == "y")
        {
            roll++;
            runProgram = true;
            break;
        }
        else if (input2 == "n")
        {
            Console.WriteLine("Thanks for playing!");
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
        }
    }
    //Methods
    static int RandomNumberGenerator(int size)
    {
        Random rnd = new Random();
        return rnd.Next(1, size);
    }

    static string Combinations(int dice1, int dice2)
    {
        if (dice1 == 1 && dice2 == 1)
        {
            return "Snake Eyes";
        }
        else if (dice1 == 1 && dice2 == 2)
        {
            return "Ace Deuce";
        }
        else if (dice1 == 2 && dice2 == 1)
        {
            return "Ace Deuce";
        }
        else if (dice1 == 6 && dice2 == 6)
        {
            return "Boxcars";
        }
        else
        {
            return "";
        }

    }


        static string WinOrCraps(int dice1, int dice2)
        {
            if (dice1 + dice2 == 7)
            {
                return "Win!";
            }
            else if (dice1 + dice2 == 11)
            {
                return "Win!";
            }
            else if (dice1 + dice2 == 2)
            {
                return "Craps!";
            }
            else if (dice1 + dice2 == 3)
            {
                return "Craps!";
            }
            else if (dice1 + dice2 == 12)
            {
                return "Craps!";
            }
            else
            {
                return "";
            }
        }
    }
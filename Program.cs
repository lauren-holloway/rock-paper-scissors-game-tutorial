using System;

public class RockPaperScissorsGameTutorial
{
    static void Main(string[] args)
    {
        //Welcome player
        Console.WriteLine("Let's play Rock, Paper, Scissors!");

        //Player menu
        Console.WriteLine("Choose your move...");
        Console.WriteLine("[1] ROCK");
        Console.WriteLine("[2] PAPER");
        Console.WriteLine("[3] SCISSORS");

        //Get user input for player move
        int playerMove = Convert.ToInt32(Console.ReadLine());

        //Generate randomized computer player move
        Random random = new Random();
        int cpuMove = random.Next(1, 4);
        
        //Conditions for choosing a winner
        if(playerMove == cpuMove)
        {
            Console.WriteLine("It's a draw!");
        }
        else if(playerMove == 1 && cpuMove == 2)
        {
            Console.WriteLine("Paper! You Lose...");
        }
        else if(playerMove == 1 && cpuMove == 3)
        {
            Console.WriteLine("Scissors! You win!");
        }
        else if(playerMove == 2 && cpuMove == 1)
        {
            Console.WriteLine("Rock! You win!");
        }
        else if(playerMove == 2 && cpuMove == 3)
        {
            Console.WriteLine("Scissors! You lose...");
        }
        else if(playerMove == 3 && cpuMove == 1)
        {
            Console.WriteLine("Rock! You lose...");
        }
        else if(playerMove == 3 && cpuMove == 2)
        {
            Console.WriteLine("Paper! You win!");
        }
        else
        {
            Console.WriteLine("Invalid move.");
        }
    }
}

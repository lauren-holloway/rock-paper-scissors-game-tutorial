using System;

public class RockPaperScissorsGameTutorial
{
    static void Main(string[] args)
    {
        //Overall scorekeeper variables to track overall score of rounds
        int playerScore = 0;
        int cpuScore = 0;
        
        //Welcome player
        Console.WriteLine("Let's play Rock, Paper, Scissors! We will play 3 times!");

        //Add a for loop to repeat the game 3x
        for(int i = 0; i < 3; i++)
        {
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
            if (playerMove == cpuMove)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (playerMove == 1 && cpuMove == 2)
            {
                Console.WriteLine("Paper! You Lose...");
                cpuScore++;
            }
            else if (playerMove == 1 && cpuMove == 3)
            {
                Console.WriteLine("Scissors! You win!");
                playerScore++;
            }
            else if (playerMove == 2 && cpuMove == 1)
            {
                Console.WriteLine("Rock! You win!");
                playerScore++;
            }
            else if (playerMove == 2 && cpuMove == 3)
            {
                Console.WriteLine("Scissors! You lose...");
                cpuScore++;
            }
            else if (playerMove == 3 && cpuMove == 1)
            {
                Console.WriteLine("Rock! You lose...");
                cpuScore++;
            }
            else if (playerMove == 3 && cpuMove == 2)
            {
                Console.WriteLine("Paper! You win!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Invalid move.");
            }
        }

        //Add conditional to declare the overall winner of the 3 rounds
        if(playerScore > cpuScore)
        {
            Console.WriteLine("Your Score: {0} | CPU Score: {1}\n YOU'RE THE WINNER!",playerScore,cpuScore);
        }
        else if(playerScore < cpuScore)
        {
            Console.WriteLine("Your Score: {0} | CPU Score: {1}\n CPU PLAYER IS THE WINNER!", playerScore, cpuScore);
        }
        else
        {
            Console.WriteLine("Your Score: {0} | CPU Score: {1}\n IT'S A DRAW!", playerScore, cpuScore);
        }
    }

        
}

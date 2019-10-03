using System;

namespace rockpaperscissors
{
  class Program
  {
    static void Main(string[] args)
    {
      string inputPlayer, inputCPU;
      int randomInt;
      int scorePlayer = 0;
      int scoreCPU = 0;
      bool playAgain = true;

      while (playAgain)
      {



        while (scorePlayer < 3 && scoreCPU < 3)
        {
          Console.Write("Choose ROCK, PAPER or SCISSORS: ");
          inputPlayer = Console.ReadLine().ToUpper();

          Random rnd = new Random();
          randomInt = rnd.Next(1, 4);

          switch (randomInt)
          {
            case 1:
              inputCPU = "ROCK";
              Console.WriteLine("Comupter chose ROCK");
              if (inputPlayer == "ROCK")
              {
                Console.WriteLine("Draw!");
              }
              else if (inputPlayer == "PAPER")
              {
                Console.WriteLine("Player Wins!");
                scorePlayer++;
              }
              else if (inputPlayer == "SCISSORS")
              {
                Console.WriteLine("Computer wins!");
                scoreCPU++;
              }
              break;
            case 2:
              inputCPU = "PAPER";
              Console.WriteLine("Comupter chose PAPER!");
              if (inputPlayer == "ROCK")
              {
                Console.WriteLine("Computer Wins!");
                scoreCPU++;
              }
              else if (inputPlayer == "PAPER")
              {
                Console.WriteLine("Draw!");
              }
              else if (inputPlayer == "SCISSORS")
              {
                Console.WriteLine("player wins!");
                scorePlayer++;
              }
              break;
            case 3:
              inputCPU = "SCISSORS";
              Console.WriteLine("Comupter chose SCISSORS");
              if (inputPlayer == "ROCK")
              {
                Console.WriteLine("Player wins!");
                scorePlayer++;
              }
              else if (inputPlayer == "PAPER")
              {
                Console.WriteLine("Computer Wins!");
                scoreCPU++;
              }
              else if (inputPlayer == "SCISSORS")
              {
                Console.WriteLine("Draw!");
              }
              break;
            default:
              Console.WriteLine("Invalid entry.");
              break;
          }
        }
        if (scorePlayer == 3)
        {
          Console.WriteLine("Player WON!");
        }
        else if (scoreCPU == 3)
        {
          Console.WriteLine("Computer WON!");
        }
        Console.WriteLine("Do you want to play again?");
        string loop = Console.ReadLine().ToUpper();
        if (loop == "Y")
        {
          playAgain = true;
        }
        else if (loop == "N")
        {
          playAgain = false;
        }
        else
        {
          Console.WriteLine("Please enter 'Y' or 'N':");
        }

      }
    }
  }
}

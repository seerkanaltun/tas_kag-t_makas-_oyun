using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tas_kagıt_makas__oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, computerScore = 0;
            string exitKey = "";
            while (exitKey != "e")
            {
                Console.Clear();
                Console.WriteLine("Rock-Paper-Scissors");
                Console.WriteLine("Choose [r]ock,[p]aper,[s]cissors or [e]xit");
                string playerMove = "";
            GetInput:
                switch (Console.ReadLine().ToLower())
                {
                    case "r":
                        playerMove = "rock";
                        break;
                    case "p":
                        playerMove = "paper";
                        break;
                    case "s":
                        playerMove = "scissors";
                        break;
                    case "e":
                        exitKey = "e";
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input... Please try again.");
                        goto GetInput;
                        break;
                }
                Console.WriteLine($"Your choose {playerMove}");
                Random rnd = new Random();
                int random = rnd.Next(3); //0,1,2
                string computerMove = "";
                switch (random)
                {
                    case 0:
                        computerMove = "rock";
                        break;
                    case 1:
                        computerMove = "paper";
                        break;
                    case 2:
                        computerMove = "scissors";
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"Computer's move {computerMove}");
                if ((playerMove == "rock" && computerMove == "paper") || (playerMove == "scissors" && computerMove == "rock") || (playerMove == "paper" && computerMove == "scissors"))//bilgisayarın kazandığı ihtimaller.et
                {
                    computerScore++;
                    Console.WriteLine("You lost. Computer won.");
                }
                else if ((playerMove == "rock" && computerMove == "scissors") || (playerMove == "scissors" && computerMove == "paper") || (playerMove == "paper" && computerMove == "rock"))

                {
                    playerScore++;
                    Console.WriteLine("You won. Computer lost.");
                }
                else
                {
                    Console.WriteLine("Draw / Game is tie.");
                }
                Console.WriteLine($"Your score {playerScore} and Computer's score {computerScore}");
                Console.WriteLine("Press enter to continue");

                Console.ReadKey();
            }
        }
    }
}

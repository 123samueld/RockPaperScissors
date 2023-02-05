using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcme to Rock Paper Scissors!");

            bool gameRunning = true;
            string[] options = new string[] { "rock", "paper", "scissors" };
            string selectionPlayer;
            string selectionCPU;
            Random rand = new Random();
            int randInt;

            while(gameRunning)
            {
                selectionPlayer = "";
                randInt = rand.Next(0, 3);

                selectionCPU = "";
                while(selectionPlayer != "rock" && selectionPlayer != "paper" && selectionPlayer != "scissors")
                {
                    Console.WriteLine("Please choose Rock, Paper or Scissors: ");
                    selectionPlayer = Console.ReadLine().ToLower();
                }
                Console.WriteLine("Player chose: "+selectionPlayer);
                selectionCPU = options[randInt];
                Console.WriteLine("CPU chose: " + selectionCPU);

                switch (selectionPlayer)
                {
                    case "rock":
                        if(selectionCPU == "scissors")
                        {
                            Console.WriteLine("Player wins.");
                        }
                        else if(selectionCPU == "paper")
                        {
                            Console.WriteLine("CPU wins");
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                    case "paper":
                        if (selectionCPU == "rock")
                        {
                            Console.WriteLine("Player wins.");
                        }
                        else if (selectionCPU == "scissors")
                        {
                            Console.WriteLine("CPU wins");
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                    case "scissors":
                        if (selectionCPU == "paper")
                        {
                            Console.WriteLine("Player wins.");
                        }
                        else if (selectionCPU == "rock")
                        {
                            Console.WriteLine("CPU wins");
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;

                }


            }
            Console.WriteLine("Thank you for playing Rock Paper Scissors.");
        }
    }
}

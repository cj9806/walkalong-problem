using System;
/// <summary>
/// An Unimaginative Guess the number engine
/// Deliberatly dumb.
/// With some deliberate logic
/// </summary>
namespace GuessTheNumber
{
    class Program
    {
        /// <summary>
        /// Main is your programs entrypoint, for most purposes you should
        /// regard it as being the first piece of code in your program that will be executed.
        /// (this is almost 99% true, and is good enough for now.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                Random nGenerator = new Random();
                //Some error trapping
                if (args.Length == 0)
                {
                    Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                    return;
                }
                Console.WriteLine("How many tries would you like?");
                string numOfTries = Console.ReadLine();
                int numberOfTries = int.Parse(numOfTries);
                Console.WriteLine("Gve me the highest number to guess");
                string maxNum = Console.ReadLine();
                int ceiling = int.Parse(maxNum);


                int myNumber = nGenerator.Next(ceiling);

                string playerGuess = "";
                int playerGuessNum = 0;
                Console.WriteLine($"I am thinking of a whole number between 0 and {ceiling}");
                Console.WriteLine($"Can you try and guess it in less than {numberOfTries} tries ?");

                for (int i = numberOfTries; i >= 0 && playerGuessNum != myNumber; i--)//for loop running the main program
                {
                    Console.WriteLine("You have " + i.ToString() + " tries left.");
                    if(i == 0)
                    {
                        Console.WriteLine("you lose");
                        break;
                    }
                    Console.WriteLine("Take a guess ?");
                    playerGuess = Console.ReadLine();
                    playerGuessNum = int.Parse(playerGuess);
                    
                    if (playerGuessNum > myNumber)//too high
                    {
                        Console.WriteLine("Too High, Try again.");
                    }//too high
                    else if (playerGuessNum < myNumber)
                    {
                        Console.WriteLine("Too Low, Try again.");
                    }// too low
                    else if (playerGuessNum == myNumber)
                    {
                        Console.WriteLine($"Well Done. You took {numberOfTries - i + 1} attempts.");
                    }//if you win
                    
                }
                Console.WriteLine("let's play again.");
                Console.ReadLine();
                
            }        
        }
    }
}

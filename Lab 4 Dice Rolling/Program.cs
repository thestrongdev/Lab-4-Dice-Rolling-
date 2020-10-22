using System;

namespace Lab_4_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Grand Circus Casino!!!");

            if (AskUser() == true)
            {
                PlayGame();
            }

        }

        static int ValidateSides()
        {
            int sides;

            do
            {
                Console.WriteLine("Please enter the number of sides of your dice");
                string numSides = Console.ReadLine();
                bool realInteger = int.TryParse(numSides, out sides);

                if (realInteger)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input...Please enter a whole number");
                    continue;
                }
            } while (true);
            return sides;
        }

        static bool AskUser()
        {
            bool startGame = true;
            do
            {
                Console.WriteLine("Would you like to roll the dice (y/n)");

                string userInput = Console.ReadLine();

                userInput = userInput.ToLower();
                if (userInput.Equals("y"))
                {
                    startGame = true;
                    break;
                }
                else if (userInput.Equals("n"))
                {
                    startGame = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input try again.");
                    continue;
                }
            } while (true);
            return startGame;

        }

        static void PlayGame()
        {
            int sides = ValidateSides();
            bool keepPlaying = true;
            int rollCount = 1;

            do
            {
                Console.WriteLine($"Roll {rollCount}: ");
                Console.WriteLine(RandomNumber(sides));
                Console.WriteLine(RandomNumber(sides));

                rollCount++;

            } while (keepPlaying = ContinueGame());
        }

        static int RandomNumber(int x)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, x);
            return randomNumber;
        }


        static bool ContinueGame()
        {
            bool continueGame = true;
            do
            {
                Console.WriteLine(" Do you want to continue? (Y/N)");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                if (userInput.Equals("y"))
                {
                    continueGame = true;
                    break;
                }
                else if (userInput.Equals("n"))
                {
                    continueGame = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input try again.");
                    continue;
                }
            } while (true);
            return continueGame;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _02_DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine(
               $"Dice rolled. Guess what number it shows in {InitialTries} tries.");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                Console.WriteLine($"You have {triesLeft} tries left. Enter your guess (1-6):");
                var guess = Convert.ToInt32(Console.ReadLine());

                if(guess == diceRollResult)
                {
                    return GameResult.Victory;
                }

                Console.WriteLine("Wrong number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            if (gameResult == GameResult.Victory)
            {
                Console.WriteLine("Congratulations! You've guessed the correct number!");
            }
            else
            {
                Console.WriteLine("Sorry, you've used all your tries. Better luck next time!");
            }
        }
    }
}

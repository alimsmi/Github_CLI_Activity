using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingCliGame
{
    public class Game
    {
        public Game() { }
        public void CreateUserInterFace() 
        {
            Console.WriteLine("Welcome to the Number Guessing Game!\r\nI'm thinking of a number between 1 and 100.");
            Console.WriteLine("Choose The difficulity level : ");
            ReCheck:
            Console.WriteLine();
            Console.WriteLine("1.Easy (10 chances)");
            Console.WriteLine("2.Medium (5 chances)");
            Console.WriteLine("3.Hard (3 chances)");
            char choise = Console.ReadLine()[0];
            if(choise > '3' ||choise < 1)
            { 
                Console.WriteLine("Choise Must be 1,2,3\nTry Again");
                goto ReCheck;
            }
            string difficullityLevel = string.Empty;
            switch (choise)
            {
                case '1':
                    difficullityLevel = "Easy";
                    break;
                case '2':
                    difficullityLevel = "Medium";
                    break;
                case '3':
                    difficullityLevel = "Hard";
                    break;
            }
            Console.WriteLine($"Great! you selected the {difficullityLevel} difficulity level.\nLet's start the game");
            StartGame(difficullityLevel);
        }
        private void StartGame(string difficulity) 
        {
            int chances = 0;
            switch (difficulity) 
            {
                case "Easy":
                    chances = 10;
                    break;
                case "Medium":
                    chances = 5;
                    break;
                case "Hard":
                    chances = 3;
                    break;
            }
            int rndNum = GetRandomNumber();
            for (int i = 0; i <= chances; i++) 
            {
                Console.Write("Enter your guess : ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > rndNum)
                    Console.WriteLine("Incorect Number is less than "+guess);
                if (guess < rndNum)
                    Console.WriteLine("Incorect Number is greater than " + guess);
                if (guess == rndNum)
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number in {i} attempts.");
                    return;
                }
            }
            Console.WriteLine("Sorry you are lose number was "+rndNum);
        }
        private int GetRandomNumber() 
        {
            int rnd = new Random().Next(1,100);
            return rnd;
        }
    }
}

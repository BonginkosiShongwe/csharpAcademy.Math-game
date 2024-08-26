﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE MATH GAME");
            Console.WriteLine();
            Console.WriteLine("What game would you like to play? Choose from the options below: ");
            Console.WriteLine();
            Console.WriteLine("V - View Previous Games");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("Q - Quit the program");
            Console.WriteLine("----------------------------------------------------------------");

            char cOption = char.Parse(Console.ReadLine());

            switch (cOption)
            {
                case 'V':
                    {
                        //view previous games
                    }
                    break;
                case 'A':
                    {
                        Addition();
                        Console.WriteLine("Press any key to go back to the menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        Main(args);
                        
                    }
                    break;
                case 'S':
                    {

                    }
                    break;
                case 'M':
                    {
                        //subtract
                    }
                    break;
                case 'D':
                    {
                        //Division
                    }
                    break;
                case 'Q':
                    {
                        //quit
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect option!");
                    break;
            }

            Console.ReadKey();
        }//main
        //Addition method
        static void Addition()
        {
            int[] firstNumber = { 3, 76, 43, 97, 46, 96, 58, 32, 64, 76 };
            int[] secondNumber = { 2, 23, 45, 76, 12, 24, 90, 87, 84, 12 };

            int[] usedIndices = new int[6];

            Random random = new Random();
            int score = 0;

            for (int k = 1; k < usedIndices.Length; k++)
            {

                int randomIntInRange;

                do
                {
                    randomIntInRange = random.Next(firstNumber.Length - 1);
                }
                while (usedIndices.Contains(randomIntInRange));

                usedIndices[k] = randomIntInRange;

                Console.Write($"{k}. " + firstNumber[randomIntInRange] + " + " + secondNumber[randomIntInRange] + " = ");

                int iAnswer = int.Parse(Console.ReadLine());

                if(iAnswer == firstNumber[randomIntInRange] + secondNumber[randomIntInRange])
                {
                    Console.WriteLine("Correct! ");
                    score += 10;
                }
                else
                {
                    Console.WriteLine("Incorrect !");
                }
             }
            Console.WriteLine($"You got {(score/50.00)*100}%");
        }

        static void Subtraction()
        {
            string[] subQuestions = { "21 - 6", "32 - 7", "7 - 8", "101 - 12", "46 - 17", "67 - 56" };
        }

        static void Multiplication()
        {
            string[] multiQuestions = { "2 * 6", "3 * 7", "7 * 8", "11 * 12", "46 * 17", "67 * 56" };
        }

        static void Division()
        {
            string[] divQuestions = { "12 / 6", "42 / 7", "72 / 8", "144 / 12", "51 / 17", "168 / 56" };
        }

        static void View()
        {

        }
    }
}

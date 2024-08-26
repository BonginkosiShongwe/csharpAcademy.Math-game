using System;
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
                        Subtraction();
                        Console.WriteLine("Press any key to go back to the menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case 'M':
                    {
                        Multiplication();
                        Console.WriteLine("Press any key to go back to the menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case 'D':
                    {
                        Division();
                        Console.WriteLine("Press any key to go back to the menu");
                        Console.ReadKey(true);
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case 'Q':
                    {
                        Console.WriteLine("Thank you for playing! ");
                        Console.WriteLine("Press any key to quit! ");
                        break;
                    }
                    //break;
                default:
                    Console.WriteLine("Incorrect option!");
                    break;
            }

            Console.ReadKey();
        }//main
        //Addition
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
        //Subtraction
        static void Subtraction()
        {
            int[] firstsubNumber = { 13, 76, 143, 907, 46, 96, 88, 81, 64, 76 };
            int[] secondsubNumber = { 2, 23, 45, 76, 12, 24, 90, 87, 84, 12 };

            int[] usedIndices = new int[6];

            Random random = new Random();
            int score = 0;

            for (int k = 1; k < usedIndices.Length; k++)
            {

                int randomIntInRange;

                do
                {
                    randomIntInRange = random.Next(firstsubNumber.Length - 1);
                }
                while (usedIndices.Contains(randomIntInRange));

                usedIndices[k] = randomIntInRange;

                Console.Write($"{k}. " + firstsubNumber[randomIntInRange] + " - " + secondsubNumber[randomIntInRange] + " = ");

                int iAnswer = int.Parse(Console.ReadLine());

                if (iAnswer == firstsubNumber[randomIntInRange] - secondsubNumber[randomIntInRange])
                {
                    Console.WriteLine("Correct! ");
                    score += 10;
                }
                else
                {
                    Console.WriteLine("Incorrect !");
                }
            }
            Console.WriteLine($"You got {(score / 50.00) * 100}%");

        }
        //Multiplication
        static void Multiplication()
        {
            int[] firstmultiNumber = { 13, 76, 3, 7, 46, 9, 88, 3, 4, 6 };
            int[] secondmultiNumber = { 2, 3, 45, 76, 12, 24, 9, 87, 84, 12 };

            int[] usedIndices = new int[6];

            Random random = new Random();
            int score = 0;

            for (int k = 1; k < usedIndices.Length; k++)
            {

                int randomIntInRange;

                do
                {
                    randomIntInRange = random.Next(firstmultiNumber.Length - 1);
                }
                while (usedIndices.Contains(randomIntInRange));

                usedIndices[k] = randomIntInRange;

                Console.Write($"{k}. " + firstmultiNumber[randomIntInRange] + " x " + secondmultiNumber[randomIntInRange] + " = ");

                int iAnswer = int.Parse(Console.ReadLine());

                if (iAnswer == firstmultiNumber[randomIntInRange] * secondmultiNumber[randomIntInRange])
                {
                    Console.WriteLine("Correct! ");
                    score += 10;
                }
                else
                {
                    Console.WriteLine("Incorrect !");
                }
            }
            Console.WriteLine($"You got {(score / 50.00) * 100}%");
        }
        //Division
        static void Division()
        {
            int[] inumerator = { 14, 92, 90, 152, 96, 120, 180, 49, 64, 60 };
            int[] idenomenator = { 2, 23, 45, 76, 12, 24, 90, 7, 4, 12 };

            int[] usedIndices = new int[6];

            Random random = new Random();
            int score = 0;

            for (int k = 1; k < usedIndices.Length; k++)
            {

                int randomIntInRange;

                do
                {
                    randomIntInRange = random.Next(inumerator.Length - 1);
                }
                while (usedIndices.Contains(randomIntInRange));

                usedIndices[k] = randomIntInRange;

                Console.Write($"{k}. " + inumerator[randomIntInRange] + " / " + idenomenator[randomIntInRange] + " = ");

                int iAnswer = int.Parse(Console.ReadLine());

                if (iAnswer == inumerator[randomIntInRange] / idenomenator[randomIntInRange])
                {
                    Console.WriteLine("Correct! ");
                    score += 10;
                }
                else
                {
                    Console.WriteLine("Incorrect !");
                }
            }
            Console.WriteLine($"You got {(score / 50.00) * 100}%");
        }
 
        static void View()
        {

        }
    }
}

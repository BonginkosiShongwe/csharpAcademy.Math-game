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
            Console.WriteLine("\t\t\tWELCOME TO THE MATH GAME");
            Console.WriteLine();
            Console.WriteLine("What game would you like to play? Choose from the options below: ");
            Console.WriteLine();
            Console.WriteLine("V - View Previous Games");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("Q - Quit the program");
            Console.WriteLine("-------------------------------------------");

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
                        //Addition
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
        static void Addition()
        {
            int[] addQuestions = { (2 + 6), (3 + 7), (7 + 8), (11 + 12), (46 + 17), (67 + 56) };

            Random random = new Random();

            for (int k = 1; k <= addQuestions.Length; k++)
            {
                int randomIntInRange = random.Next(addQuestions.Length);

                Console.Write($"{k}. {addQuestions[randomIntInRange]} = ");
                int iAnswer = int.Parse(Console.ReadLine());

                if (iAnswer == addQuestions[randomIntInRange])
                {

                }
            }



        }

        static void Subtraction()
        {
            int[] subQuestions = { (21 - 6), (32 - 7), (72 - 8), (101 - 12), (46 - 17), (67 - 56) };
        }

        static void Multiplication()
        {
            int[] multiQuestions = { (2 * 6), (3 * 7), (7 * 8), (11 * 12), (46 * 17), (67 * 56) };
        }

        static void Division()
        {
            int[] divQuestions = { (12 / 6), (42 / 7), (72 / 8), (144 / 12), (34 / 17), (168 / 56) };
        }

        static void View()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("<==================>");
            Console.WriteLine("     Maths test     ");
            Console.WriteLine("<==================>");

            Console.Write("Please enter your Name: ");
            string userName = (Console.ReadLine());

            Console.WriteLine("Hello " + userName + ", Press ENTER to start the Math Quiz");

            Console.WriteLine();
            Console.ReadKey();

        Start:

            Random numberGenerator = new Random();
            int score = 0;

            while (true)
            {
                int num01 = numberGenerator.Next(1, 11);
                int num02 = numberGenerator.Next(1, 11);

                Console.WriteLine("What is " + num01 + " times " + num02 + " equal to?");

                int Answer = Convert.ToInt32(Console.ReadLine());
                int correctAnswer = num01 * num02;

                if (Answer == num01 * num02)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    ++score;
                    int responseIndex = numberGenerator.Next(1, 5);
                    switch (responseIndex)
                    {
                        case 1:
                            Console.WriteLine("Great!");
                            Console.WriteLine("Your score: " + score);
                            break;
                        case 2:
                            Console.WriteLine("You nailed it!");
                            Console.WriteLine("Your score: " + score);
                            break;
                        case 3:
                            Console.WriteLine("You're correct!");
                            Console.WriteLine("Your score: " + score);
                            break;
                        default:
                            Console.WriteLine("Good Job " + userName + ", Keep it up!");
                            Console.WriteLine("Your score: " + score);
                            break;
                    }
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    int responseIndex2 = numberGenerator.Next(1, 5);
                    switch (responseIndex2)
                    {
                        case 1:
                            Console.WriteLine("Are you even trying? The correct answer is " + correctAnswer);
                            break;
                        case 2:
                            Console.WriteLine("Ooops!!! The correct answer is " + correctAnswer);
                            break;
                        case 3:
                            Console.WriteLine("Oh, come on " + userName + " I know you can do better than that! The correct answer is " + correctAnswer);
                            break;
                        default:
                            Console.WriteLine("Sorry " + userName + ", that's incorrect, the correct answer is " + correctAnswer);
                            break;
                    }
                    Console.WriteLine(Environment.NewLine + "Game Over, Your score: " + score);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ReadLine();
                    goto Start;

                }
            }
        }
    }
}
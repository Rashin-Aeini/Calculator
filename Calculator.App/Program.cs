using System;
using System.Collections.Generic;

namespace Calculator.App
{
    public static class Program
    {
        static void Main()
        {
            int menu;
            do
            {
                Console.WriteLine("Please Select your operation\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n0.Exit");
                menu = Select(new[] {0, 4});

                if (menu != 0)
                {
                    int selection = 1;
                    List<float> entry = new List<float>();
                    if (menu == 1 || menu == 2)
                    {
                        Console.WriteLine("Please enter type entry\n1.Single\n2.Multi");
                        selection = Select(new[] {1, 2});
                        if (selection == 2)
                        {
                            
                            Console.WriteLine("Please enter your numbers \n and For ending please enter enything except numbers");
                            bool isNumber;

                            do
                            {
                                string line = Console.ReadLine();
                                isNumber = float.TryParse(line, out float result);
                                if (isNumber)
                                {
                                    entry.Add(result);
                                }
                            } while (isNumber);
                        }
                    }

                    int first = 0, second = 0;

                    if (selection != 2)
                    {
                        Console.WriteLine("Please enter first number");
                        first = Select(new[] {Int32.MinValue, int.MaxValue});
                        Console.WriteLine("Please enter second number");
                        second = Select(new[] {Int32.MinValue, int.MaxValue});
                    }

                    Calc calc = new Calc();
                    switch ((Action) menu)
                    {
                        case Action.Addition:
                        {
                            if (selection == 1)
                            {
                                Console.WriteLine("Result of addition between the number of {0} and {1} is {2}", first, second, calc.Addition(first, second));
                            }
                            else
                            {
                                Console.Write("Result of addition in the numbers of");
                                int count = 1;
                                foreach (float item in entry)
                                {
                                    Console.Write(count == entry.Count ? " and {0}" : " {0},", item);

                                    count++;
                                }
                                Console.WriteLine(" is {0}", calc.Addition(entry.ToArray()));
                            }
                            break;
                        }
                        case Action.Subtraction:
                        {
                            if (selection == 1)
                            {
                                Console.WriteLine("Result of subtraction between the number of {0} and {1} is {2}", first, second, calc.Subtraction(first, second));
                            }
                            else
                            {
                                Console.Write("Result of subtraction in the numbers of");
                                int count = 0;
                                foreach (float item in entry)
                                {
                                    Console.Write(count == entry.Count ? " and {0}" : " {0},", item);

                                    count++;
                                }
                                Console.WriteLine(" is {0}", calc.Subtraction(entry.ToArray()));
                            }
                            break;
                        }
                        case Action.Multiplication:
                        {
                            Console.WriteLine("Result of multiplication between the number of {0} and {1} is {2}", first, second, calc.Multiplication(first, second));
                            break;
                        }
                        case Action.Division:
                        {
                            try
                            {
                                Console.WriteLine("Result of division between the number of {0} and {1} is {2}", first, second, calc.Division(first, second));
                            }
                            catch (DivideByZeroException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

            } while (menu != 0);
            Console.WriteLine("Thank you for using our app.");
        }

        private static int Select(int[] range)
        {
            if (range.Length != 2)
            {
                throw new ArgumentException();
            }
            
            bool isNumber;
            int selection;
            do
            {
                string entry = Console.ReadLine();
                isNumber = int.TryParse(entry, out selection);
                if(isNumber && (selection < range[0] || selection > range[1]))
                {
                    Console.WriteLine("You enter wrong number");
                    isNumber = false;
                }
                if (!isNumber)
                {
                    Console.WriteLine("Please enter number from menu");
                }
            } while (!isNumber);

            return selection;
        }
    }
}

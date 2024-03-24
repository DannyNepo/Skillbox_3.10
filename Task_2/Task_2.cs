﻿using System.Runtime.CompilerServices;

namespace Skillbox
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            string cardsAmountString;
            int cardsAmount;
            int sum = 0;

            Console.WriteLine("сколько у Вас карт?");
            cardsAmountString = Console.ReadLine();
            if (cardsAmountString != string.Empty)
            {
                cardsAmount = int.Parse(cardsAmountString);
                for (int i = 0; i < cardsAmount; i++)
                {
                    Console.Write($"введите номинал {i + 1}-й карты (используйте целые числа от 2 до 10, либо J, Q, K и A):  ");
                    string currentCardName = Console.ReadLine();
                    if (currentCardName != string.Empty)
                    {
                        switch (currentCardName)
                        {
                            case "J":
                                sum += 10;
                                break;
                            case "Q":
                                sum += 10;
                                break;
                            case "K":
                                sum += 10;
                                break;
                            case "A":
                                sum += 10;
                                break;
                            default:
                                if ((int.Parse(currentCardName) > 1) && (11 > int.Parse(currentCardName)))
                                {
                                    sum += int.Parse(currentCardName);
                                }
                                else
                                {
                                    Console.WriteLine("такой карты не существует");
                                    i--;
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("отсутствует значение");
                        i--;
                    }
                }

                if (sum > 21)
                {
                    Console.WriteLine($"у Вас {sum} - Вы проиграли");
                }
                else
                {
                    Console.WriteLine($"у Вас {sum}");
                }

            }
            else { Console.WriteLine("отсутствует значение"); }
        }
    }
}
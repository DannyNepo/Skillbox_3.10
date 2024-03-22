using System.Runtime.CompilerServices;

namespace Skillbox
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            int userNumber;

            Console.Write("введите целое число для определения четности: ");
            string userNumberString = Console.ReadLine();
            if (userNumberString != string.Empty) 
            {
                userNumber = int.Parse(userNumberString);
                if (userNumber == 0)
                {
                    Console.WriteLine("получено нулевое значение");
                }

                else if (userNumber % 2 == 0)
                {
                    Console.WriteLine($"{userNumber} - четное число");
                }

                else
                {
                    Console.WriteLine($"{userNumber} - нечетное число");
                }
            }
            else
            { Console.WriteLine("отсутствует значение"); }
            
        }
    }
}
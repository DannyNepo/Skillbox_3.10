namespace Skillbox
{
    internal class Task_4
    {
        static void Main(string[] args)
        {
            int length;
            int minValue = int.MaxValue;

            Console.Write("укажите длину последовательности: ");
            string lengthString = Console.ReadLine();
            if (lengthString == string.Empty)
            {
                Console.WriteLine("отсутствует значение");
            }
            else
            {
                length = int.Parse(lengthString);
                Console.WriteLine($"введите {length} чисел:");
                for (int i = 0; i < length; i++)
                {
                    string currentValueString = Console.ReadLine();
                    if (currentValueString == string.Empty)
                    {
                        Console.WriteLine("отсутствует значение");
                        i--;
                    }
                    else
                    {
                        int currentValue = int.Parse(currentValueString);
                        if (currentValue < minValue)
                        {
                            minValue = currentValue;
                        }
                    }
                }
                Console.WriteLine($"минимальное число последовательности - {minValue}");
            }
        }
    }
}
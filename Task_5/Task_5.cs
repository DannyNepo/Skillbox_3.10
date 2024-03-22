namespace Skillbox
{
    internal class Task_5
    {
        static void Main(string[] args)
        {
            int maxValue;
            int goal;
            int triesCounter = 0;
            Random rnd = new Random();

            Console.WriteLine("введите верхнюю границу диапазона: ");
            string maxValueString = Console.ReadLine();
            if (maxValueString == string.Empty)
            {
                Console.WriteLine("отсутствует значение");
            }
            else
            {
                maxValue = int.Parse(maxValueString);
                goal = rnd.Next(maxValue + 1);
                Console.WriteLine($"угадайте случайное целое число в диапазоне от 0 до {maxValue}");
                while (true)
                {
                    string value = Console.ReadLine();
                    if (value == string.Empty)
                    {
                        Console.WriteLine($"количество попыток: {triesCounter} правильный ответ: {goal}");
                        break;
                    }
                    else
                    {
                        triesCounter++;
                        int currentVar = int.Parse(value);
                        if (currentVar == goal)
                        {
                            Console.WriteLine($"вы угадали! количество попыток: {triesCounter}");
                            break;
                        }
                        else
                        {
                            if (currentVar > goal)
                            {
                                Console.WriteLine($"{currentVar} больше искомого числа");
                            }
                            else
                            {
                                Console.WriteLine($"{currentVar} меньше искомого числа");
                            }
                        }
                    }
                }
            }
        }
    }
}
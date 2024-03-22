namespace Skillbox
{
    internal class Task_3
    {
        static void Main(string[] args)
        {
            int userNumber;
            bool isSimple = true;

            Console.WriteLine("введите число для проверки: ");
            string userNumberString = Console.ReadLine();
            if (userNumberString == string.Empty)
            {
                Console.WriteLine("отсутсвует значение");
            }
            else
            {
                userNumber = Math.Abs(int.Parse(userNumberString));
                int i = 2;
                while (i < userNumber)
                {
                    if (userNumber % i == 0)
                    {
                        isSimple = false;
                    }
                    i++;
                }
                if (isSimple)
                {
                    Console.WriteLine($"число {userNumber} - простое");
                }
                else
                {
                    Console.WriteLine($"число {userNumber} не является простым");
                }
            }
        }
    }
}
namespace LeapYearChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка високосного года");
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine()!);

            if (year % 4 == 0)
            {
                Console.WriteLine($"{year} — високосный год.");
            }
            else
            {
                Console.WriteLine($"{year} — не високосный год.");
            }
        }
    }
}


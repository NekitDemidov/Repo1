namespace LeapYearChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка високосного года");
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine()!);

            bool isLeap = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            Console.WriteLine(isLeap ? $"{year} — високосный год." : $"{year} — не високосный год.");
        }
    }
}

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Вы ввели число a - '{a}', число b - '{b}'");

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
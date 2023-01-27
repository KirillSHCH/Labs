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

            string[] actions = { "Сложение", "Вычитание", "Умножение", "Деление", "Найти остаток" };

            int action = 0;
            bool actionCorrect = false;

            do
            {
                int index = 1;

                Console.WriteLine("Выберите операцию:");
                foreach (string item in actions)
                {
                    Console.WriteLine($"{index} - {item}");
                    index++;
                }

                action = Convert.ToInt32(Console.ReadLine());

                actionCorrect = ((action > 0) && (action <= actions.Length));
            } while (!actionCorrect);
            

            Console.WriteLine($"Вы ввели число a - '{a}', число b - '{b}'");

            switch (action)
            {
                case 1:
                    Sum(a, b);
                    break;

                case 2:
                    Sub(a, b);
                    break;

                case 3:
                    Mul(a, b);
                    break;

                case 4:
                    SafeDiv(a, b);
                    break;

                case 5:
                    FindReminder(a, b);
                    break;

                default: 
                    Sum(a, b);
                    break;
            }

            SquareNumbers(a, b);

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }

        private static double Sum(double a,double b)
        {
            double result = a + b;

            Console.WriteLine($"a + b = { result }");

            return result;
        }

        private static double Sub(double a,double b)
        {
            double result = a - b;

            Console.WriteLine($"a - b = {a - b}");

            return result;
        }

        private static double Mul(double a,double b)
        {
            double result = a * b;

            Console.WriteLine($"a * b = {a * b}");

            return result;
        }

        private static double SafeDiv(double a,double b)
        {
            if (b == 0)
            {
                Console.WriteLine($"Деление невозможно: На ноль делить нельзя");
                return 0;
            }

            double result = a / b;

            Console.WriteLine($"a / b = {a / b}");

            return result;
        }

        private static double FindReminder(double a,double b)
        {
            double result;

            if (a >= b)
            {
                result = a % b;
                Console.WriteLine($"Остаток от a % b = {result}");
            }
            else
            {
                result = b % a;
                Console.WriteLine($"Остаток от b % a = {result}");
            }

            return result;
        }

        private static double SquareNumbers(double a,double b)
        {
            double result;

            if ((a % 2 == 0) && (b % 2 == 0))
            {
                result = Math.Pow((a + b), 2);
                Console.WriteLine($"(a + b)^2 = {result}");
            }
            else
            {
                result = Math.Pow((a - b), 2);
                Console.WriteLine($"(a - b)^2 = {result}");
            }

            return result;
        }
    }
}
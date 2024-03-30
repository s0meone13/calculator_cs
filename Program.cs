using System;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 0;

        char choice;

        do
        {
            Console.WriteLine("Меню выбора:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("0. Выйти из программы");

            Console.Write("Выберите пункт меню: ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    Console.WriteLine("Введите значение A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Вы ввели A = " + a);
                    break;
                case '2':
                    Console.WriteLine("Введите значение B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Вы ввели B = " + b);
                    break;
                case '3':
                    Console.WriteLine($"Результат сложения A + B: {a + b}");
                    break;
                case '4':
                    Console.WriteLine($"Результат вычитания A - B: {a - b}");
                    break;
                case '5':
                    Console.WriteLine($"Результат умножения A * B: {a * b}");
                    break;
                case '6':
                    if (b != 0)
                    {
                        Console.WriteLine($"Результат деления A / B: {(double)a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                    }
                    break;
                case '0':
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        } while (choice != '0');
    }
}
using System;
using calculator;

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
                    InputA.InputValue(ref a, "Введите значение A:");
                    break;
                case '2':
                    InputB.InputValue(ref b, "Введите значение B:");
                    break;
                case '3':
                    Addition.PerformOperation(a, b);
                    break;
                case '4':
                    Subtraction.PerformOperation(a, b);
                    break;
                case '5':
                    Multiplication.PerformOperation(a, b);
                    break;
                case '6':
                    Division.PerformOperation(a, b);
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











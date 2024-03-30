using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public static class Division
    {
        public static void PerformOperation(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Результат деления A / B: {(double)a / b}");
            }
            else
            {
                Console.WriteLine("Деление на ноль невозможно.");
            }
        }
    }
}

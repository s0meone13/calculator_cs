using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public static class InputA
    {
        public static void InputValue(ref int value, string message)
        {
            Console.WriteLine(message);
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели A = " + value);
        }
    }
}

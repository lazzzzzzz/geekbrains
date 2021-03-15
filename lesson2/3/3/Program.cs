using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Некорректные данные введите целое число");
            if (number % 2 == 0)
                Console.WriteLine("Чет");
            else
                Console.WriteLine("нечет");
        }
    }
}

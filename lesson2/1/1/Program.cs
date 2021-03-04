using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную и минимальную температуру числом.");
            int maxTemp, minTemp;
            while (!(int.TryParse(Console.ReadLine(), out maxTemp)&&int.TryParse(Console.ReadLine(), out minTemp)))
                Console.WriteLine("Некорректные данные введите максимальную и минимальную температуру числом.");
            double avgTemp = (double)(maxTemp + minTemp) / 2;
            Console.WriteLine($"Среднесуточная температура:{avgTemp} градусов цельсия");
        }
    }
}

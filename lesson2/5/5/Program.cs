using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную и минимальную температуру числом.");
            int maxTemp, minTemp;
            while (!(int.TryParse(Console.ReadLine(), out maxTemp) && int.TryParse(Console.ReadLine(), out minTemp)))
                Console.WriteLine("Некорректные данные введите максимальную и минимальную температуру числом.");
            double avgTemp = (double)(maxTemp + minTemp) / 2;
            Console.WriteLine("Введите нормер месяца");
            string[] mounth = new string[]{ "январь","февраль","март","апрель","май",
                "июнь","июль","август","сентябь горит","октябрь","ноябрь","декабрь"};
            int numberOfMounth;
            while ((!int.TryParse(Console.ReadLine(), out numberOfMounth)) || numberOfMounth > 12 || numberOfMounth < 1)
                Console.WriteLine("Некорректные данные число между 1 и 12.");
            if ((numberOfMounth < 3 || numberOfMounth == 12) && avgTemp > 0)
                Console.WriteLine("Дождливая зима");
            else
            {
                Console.WriteLine(mounth[numberOfMounth - 1]);
                Console.WriteLine($"Среднесуточная температура:{avgTemp} градусов цельсия");
            }
        }
    }
}
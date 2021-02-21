using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите нормер месяца");
            string[] mounth =new string[]{ "январь","февраль","март","апрель","май",
                "июнь","июль","август","сентябь горит","октябрь","ноябрь","декабрь"};
            int numberOfMounth;
            while ((!int.TryParse(Console.ReadLine(), out numberOfMounth))||numberOfMounth>12||numberOfMounth<1)
                Console.WriteLine("Некорректные данные число между 1 и 12.");
            Console.WriteLine(mounth[numberOfMounth - 1]);
        }
    }
}

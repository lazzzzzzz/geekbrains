using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        enum Seasons
        {

            Winter,
            Spring,
            Summer,
            Autumn
        }

        static int getSeason(int month)
        {
            if (month > 0 && (month == 1 || month == 11 || month == 12))
                return (int)Seasons.Winter;
            else
                if (month > 0 && month < 6)
                return (int)Seasons.Spring;
            else
                if (month > 0 && month < 9)
                return (int)Seasons.Summer;
            else
                if (month > 0 && month < 11)
                return (int)Seasons.Autumn;
            Console.WriteLine("Ошибка: введите число от 1 до 12");
            return -1;
        }

        static string takeSeason(int season)
        {
            return ((Seasons)season).ToString();
        }

        static void Main(string[] args)
        {
            int numberOfMonth;
            if (Int32.TryParse(Console.ReadLine(), out numberOfMonth))
                Console.WriteLine(takeSeason(getSeason(numberOfMonth)));
            else
                Console.WriteLine("введите целое число между 1-12");
        }
    }
}

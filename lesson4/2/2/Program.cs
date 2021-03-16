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
            string numbers = Console.ReadLine();
            int summ = 0;
            int intNumber;
            string number;
            while (numbers.Length>0)
            {
                if (numbers.IndexOf(' ') != -1)
                {
                    number = numbers.Substring(0, numbers.IndexOf(' '));
                    numbers = numbers.Remove(0, (numbers.IndexOf(' ')+1));
                }
                else
                {
                    number = numbers;
                    numbers = "";
                }
                if (Int32.TryParse(number, out intNumber))
                    summ += intNumber;
                else
                {
                    Console.WriteLine("Некорректные данные введите заного");
                    summ = 0;
                    numbers = Console.ReadLine();
                }
            }
            Console.WriteLine(summ);
        }
    }
}

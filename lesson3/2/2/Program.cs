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
            string[,] phoneBase = new string[5, 2];
            for (int i = 0; i < phoneBase.GetLength(0); i++)
            {
                Console.WriteLine("введите имя");
                phoneBase[i, 0] = Console.ReadLine();
                Console.WriteLine("введите номер/емайл");
                phoneBase[i, 1] = Console.ReadLine();
            }
            for (int i = 0; i < phoneBase.GetLength(0); i++)
                Console.WriteLine($"пользователь:{phoneBase[i, 0]},контактные данные:{phoneBase[i, 1]}");
        }
    }
}

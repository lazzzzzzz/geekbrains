using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hell_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("как звать?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Привет {userName} Сегодня:{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}");
        }
    }
}

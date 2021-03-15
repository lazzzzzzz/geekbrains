using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("1", "2", "3"));
            Console.WriteLine(GetFullName("4", "5", "6"));
            Console.WriteLine(GetFullName("7", "8", "9"));
            var text= GetFullName("10", "11", "12");
            Console.WriteLine(text);
        }
    }
}

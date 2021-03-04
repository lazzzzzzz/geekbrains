using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] checkArray = new string[,]{ { "водичка", "60" },{ "пшеничка", "40" },{ "ежевичка","100" } };
            Console.Write(new string(' ', 7)+"ООО \"Случайный магазин\"\nг.Случайный, Пушкина,5\n\n" +
                "КАССОВЫЙ ЧЕК"+new string(' ',18)+"ПРИХОД\n" +
                new string('=',36)+"\nРМ №111\n"+new string(' ',16)+"Иванов Иван Иванович\n" +
                "ПРОДАЖА №111111"+new string(' ',10)+"СМЕНА №1111\n" + new string('=', 36)+"\n");
            for(int i=0;i<checkArray.GetLength(0);i++)
            {
                Console.WriteLine(checkArray[i, 0] + new string(' ', 36 - checkArray[i, 0].Length - checkArray[i, 1].Length)+checkArray[i,1]+
                    "\nТОВАР\nПОЛНЫЙ РАСЧЕТ");
            }
            Console.WriteLine(new string('=', 36) + "\nИТОГ" + new string(' ', 28) + "=200");
        }
    }
}

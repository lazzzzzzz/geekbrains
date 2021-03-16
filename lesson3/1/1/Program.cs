using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Доп задание вывести на экран все диагонали
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomizer = new Random();
            int arrLength, arrWidth;
            Console.WriteLine("Введите размерность массива");
            while (!(int.TryParse(Console.ReadLine(), out arrLength) && int.TryParse(Console.ReadLine(), out arrWidth)))
                Console.WriteLine("Введите размерность массива двумя целыми числами");
            int[,] randomArray = new int[arrLength, arrWidth];
            Console.Write("исходный массив");
            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arrWidth; j++)
                {
                    randomArray[i, j] = randomizer.Next(10, 99);
                    Console.Write(randomArray[i, j] + " ");
                }
            }
            Console.WriteLine("\nвсе диагонали");

            for (int i = 0; i < arrWidth+arrLength; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Math.Min(arrWidth, arrLength); j++)
                {
                    if (i <  arrLength)
                    {
                        if (j==i+1)
                            break;
                        Console.Write(randomArray[arrLength+j-i-1, j] + " ");
                    }
                    else
                    {
                        if (arrWidth+arrLength-i==j+1)
                            break;
                        Console.Write(randomArray[j,i-arrLength+j+1] + " ");
                    }
                }
            }
        }
    }
}

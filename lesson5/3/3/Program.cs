using System;
using System.IO;
using System.Collections.Generic;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вводите числа, для остановки ввода чисел введите exit");
            List<Byte> numbers= new List<byte>();
            string input;
            Byte bit;
            while((input= Console.ReadLine())!= "exit")
            {
                if (Byte.TryParse(input, out bit))
                    numbers.Add(bit);
                else
                    Console.WriteLine("введите число от 0 до 255");
            }
            File.WriteAllBytes("bin.bin", numbers.ToArray());
        }
    }
}

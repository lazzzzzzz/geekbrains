using System;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", DateTime.Now.ToShortTimeString()+"\n");
        }
    }
}

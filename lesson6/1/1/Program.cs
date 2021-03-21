using System;
using System.Diagnostics;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var processArr = Process.GetProcesses();
            string input = "";
            int code = -1;
            while (input != "exit")
            {
                Console.Clear();
                foreach (var e in processArr)
                {
                    if (e.Id == code || input==e.ProcessName)
                        e.Kill();
                    else
                        Console.WriteLine($"Имя: {e.ProcessName}  ID: {e.Id}");
                }
                input = Console.ReadLine();
                if(!Int32.TryParse(input, out code))
                    code = -1;

            }
        }
    }
}

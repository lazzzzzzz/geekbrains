using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6
{
    class Program
    {
        [Flags]
        public enum Week
        {
            Monday =  1,
            Thusday = 2,
            Wensday = 4,
            Thisday = 8,
            Friday =  16,
            Saturday =32,
            Sunday =  64,
        }
        struct OfficeSchedule
        {
            public string officeName;
            public Week schedule;
            public void getSchedule()
            {
                Console.WriteLine(officeName+"is working at "+ schedule);
            }
        }

        static void Main(string[] args)
        {
            OfficeSchedule newOffice1 = new OfficeSchedule { };
            newOffice1.officeName = "rostelekom";
            newOffice1.schedule = Week.Monday|Week.Thisday| Week.Friday;
            newOffice1.getSchedule();
            OfficeSchedule newOffice2 = new OfficeSchedule { };
            newOffice2.officeName = "ne rostelekom";
            newOffice2.schedule =(Week)0b1111111;
            newOffice2.getSchedule();
            OfficeSchedule newOffice3 = new OfficeSchedule { };
            newOffice3.officeName = "filial rostelekoma";
            newOffice3.schedule = (Week)50;
            newOffice3.getSchedule();

        }
    }
}

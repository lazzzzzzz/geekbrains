using System;
using System.Configuration;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetGreeting());
            GetUserInfo();
            Console.ReadLine();
        }

        static string GetGreeting()
        {
            try
            {
                var appCfg = ConfigurationSettings.AppSettings;
                if (appCfg["Greeting"] == null)
                {
                    throw new ArgumentNullException();
                }
                else
                    return (appCfg["Greeting"]);
            }
            catch
            {
                Console.WriteLine("что то не то");
            }
            return "-1";
        }

        static void GetUserInfo()
        {
            try
            {
                var cfgFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appCfg = cfgFile.AppSettings.Settings;
                if (appCfg["Name"].Value == "" || appCfg["Age"].Value == "" || appCfg["Work"].Value == "")
                {
                    Console.WriteLine("введи имя");
                    appCfg["Name"].Value = Console.ReadLine();
                    Console.WriteLine("введи возраст");
                    appCfg["Age"].Value = Console.ReadLine();
                    Console.WriteLine("введи работу");
                    appCfg["Work"].Value = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Имя пользователя:{appCfg["Name"].Value} \nВозраст пользователя:{appCfg["Age"].Value} " +
                        $"\nРабота пользователя:{appCfg["Work"].Value}");
                    appCfg["Name"].Value = "";
                    appCfg["Age"].Value = "";
                    appCfg["Work"].Value = "";
                }
                cfgFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(cfgFile.AppSettings.SectionInformation.Name);
            }
            catch
            {
                Console.WriteLine("что то не то");
            }
        }
    }
}


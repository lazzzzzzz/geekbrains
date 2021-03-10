using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;
namespace _5
{
    [Serializable]
    class ToDo
    {
        public List<string> Title { get; set; }
        public bool[] IsDone { get; set; }
        public void addTask(string task)
        {
            Title.Add(task);
        }
        public void CompleteTask(int i)
        {
            if (i <= Title.Count && i > 0)
                IsDone[i - 1] = !IsDone[i - 1];
            else
                Console.WriteLine("Введено некорректное число");
        }
        public void WriteList()
        {
            int i = 0;
            foreach (string str in Title)
            {
                Console.Write("{0})", i + 1);
                if (IsDone[i])
                    Console.Write("[X]");
                Console.WriteLine("{0}", str);
                i++;
            }
        }

        public void DeleteTask(int i)
        {
            i = Math.Abs(i);
            if (i <= Title.Count)
            {
                for (; i < Title.Count; i++)
                    IsDone[i - 1] = IsDone[i];
                IsDone[Title.Count - 1] = false;
                Title.RemoveAt(i - 1);
            }
            else
                Console.WriteLine("Введено некорректное число");
        }

        public void ClearList()
        {
            for (int i = 0; i < Title.Count; i++)
                IsDone[i] = false;
            Title.Clear();
        }

        public void editList()
        {

            string input = "";
            int i;
            while (true)
            {
                if (Int32.TryParse(input, out i) && i >= 0)
                    CompleteTask(i);
                else
                if (Int32.TryParse(input, out i) || i < 0)
                    DeleteTask(i);
                else
                if (input == "clear")
                    ClearList();
                else
                    if (input != "")
                    Title.Add(input);
                Console.Clear();
                Console.WriteLine("Редактирование списка:для добавления нового пункта введтие строку\n" +
                "Для отметки завершения введите индекс\nДля удаления строки введите -индекс\n" +
                "Для очистки списка введите clear\nДля выхода введите exit");
                WriteList();
                input = Console.ReadLine();
                if (input.ToLower() == "exit")
                    break;
            }
        }
        public void SerializeList()
        {
            File.WriteAllText("tasks.json", JsonSerializer.Serialize(this));
        }
        public ToDo()
        {
            Title = new List<string>();
            IsDone = new bool[100];
        }
        public ToDo(List<string> title)
        {
            Title = title;
            IsDone = new bool[100];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ToDo list = new ToDo();
            if (File.Exists("tasks.json"))
                list = JsonSerializer.Deserialize<ToDo>(File.ReadAllText("tasks.json"));
            else
                Console.WriteLine("File is not found");
            list.editList();
            list.SerializeList();
        }
    }
}

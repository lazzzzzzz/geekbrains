using System;
using System.IO;
using System.Collections.Generic;
namespace _4
{
    class Program
    {
        static string fileName = "tree.txt";
        static string fileName1 = "tree1.txt";
        static void Main(string[] args)
        {
            ClearFile(fileName1);
            ClearFile(fileName);
            string root = "D:\\шарп 1\\geekbrains\\lesson5\\4";
            CycleTree(root);
            TreeTreeTreeBydetDirka(root);
        }
        public static void CycleTree(string root)
        {
            Stack<string> dirs = new Stack<string>(50);
            if (!Directory.Exists(root))
                throw new ArgumentException();
            dirs.Push(root);
            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                subDirs = Directory.GetDirectories(currentDir);
                string[] files =  Directory.GetFiles(currentDir);
                File.AppendAllText(fileName, currentDir + "\n");
                foreach (string file in files)
                    File.AppendAllText(fileName,"     " + file.Remove(0, currentDir.Length + 1)+"\n");
                foreach (string str in subDirs)
                    dirs.Push(str);
            }
        }

        public static void TreeTreeTreeBydetDirka(string root)
        {
            if (!Directory.Exists(root))
                throw new ArgumentException();
            string[] dirs= Directory.GetDirectories(root);
            string[] files = Directory.GetFiles(root);
            File.AppendAllText(fileName1, root + "\n");
            foreach (string file in files)
                File.AppendAllText(fileName1, "     " + file.Remove(0, root.Length + 1) + "\n");
            foreach (string str in dirs)
                TreeTreeTreeBydetDirka(str);
        }

        public static void ClearFile(string file)
        {
            File.WriteAllText(file, "");
        }
    }
}

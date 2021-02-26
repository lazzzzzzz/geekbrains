using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static char[,] battleField = new char[12, 12];
        static int[] ships = { 4, 3, 3, 2, 2, 1, 1, 1, 1 };
        static bool EnviromentCheck(int xCord, int yCord, int i, int j)
        {
            if (battleField[yCord + i - 1, xCord + j - 1] == 'X' || battleField[yCord + i - 1, xCord + j] == 'X' || battleField[yCord + i - 1, xCord + j + 1] == 'X' ||
                battleField[yCord + i,     xCord + j - 1] == 'X' || battleField[yCord + i,     xCord + j] == 'X' || battleField[yCord + i,     xCord + j + 1] == 'X' ||
                battleField[yCord + i + 1, xCord + j - 1] == 'X' || battleField[yCord + i + 1, xCord + j] == 'X' || battleField[yCord + i + 1, xCord + j + 1] == 'X')
                return false;
            else return true;
        }

        static bool placeCheck(int xCord, int yCord, int shipSize, int vector)
        {
            if (vector == 1)
            {
                if (xCord + shipSize < battleField.GetLength(1) - 1)
                    for (int i = 0; i < shipSize; i++)
                    {
                        if (!EnviromentCheck(xCord, yCord, 0, i))
                            return false;
                    }
                else return false;
            }
            else
                if (vector == 2)
            {
                if (xCord - shipSize > 0)
                {
                    for (int i = 0; i > -shipSize; i--)
                        if (!EnviromentCheck(xCord, yCord, 0, i))
                            return false;
                }
                else return false;
            }
            else
                if (vector == 3)
            {
                if (yCord + shipSize < battleField.GetLength(0) - 1)
                {
                    for (int i = 0; i < shipSize; i++)
                        if (!EnviromentCheck(xCord, yCord, i, 0))
                            return false;
                }
                else return false;
            }
            else
                if (vector == 4)
            {
                if (xCord - shipSize > 0)
                {
                    for (int i = 0; i > -shipSize; i--)
                        if (!EnviromentCheck(xCord, yCord, i, 0))
                            return false;
                }
                else return false;
            }
            return true;
        }

        static void BfGeneration()
        {
            for (int i = 0; i < battleField.GetLength(0); i++)
                for (int j = 0; j < battleField.GetLength(1); j++)
                    battleField[i, j] = 'O';
            Random bfGen = new Random();
            int xCord, yCord, vector;
            for (int i = 0; i < ships.Length; i++)
            {
                xCord = bfGen.Next(1, 10);
                yCord = bfGen.Next(1, 10);
                vector = bfGen.Next(1, 4);
                while (!placeCheck(xCord, yCord, ships[i], vector))
                {
                    xCord = bfGen.Next(1, 10);
                    yCord = bfGen.Next(1, 10);
                    vector = bfGen.Next(1, 4);
                }
                for (int j = 0; j < ships[i]; j++)
                    if (vector == 1)
                        battleField[yCord, xCord + j] = 'X';
                    else
                        if (vector == 2)
                        battleField[yCord, xCord - j] = 'X';
                    else
                        if (vector == 3)
                        battleField[yCord + j, xCord] = 'X';
                    else
                        if (vector == 4)
                        battleField[yCord - j, xCord] = 'X';
            }
        }

        static void GetBattlefield()
        {
            BfGeneration();
            Console.WriteLine("  A B C D E F G H I J");
            for (int i = 1; i < battleField.GetLength(0)-1; i++)
            {
                Console.Write(i - 1);
                for (int j = 1; j < battleField.GetLength(1)-1; j++)
                    Console.Write(" " + battleField[i, j]);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            do
                GetBattlefield();
            while (Console.ReadLine() != "1");
        }
    }
}

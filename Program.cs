using System;
using System.IO;

namespace Входной_контроль_БД
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fin = new StreamReader("input.txt");
            string[,] mass = new string[8, 100];
            string[] temp = new string[100];
            int x = 0;
            while (!fin.EndOfStream)
            {
                temp[x] = fin.ReadLine();
                x++;
            }
            string[] read = new string[8];
            for (int i = 0; i < x; i++)
            {
                read = temp[i].Split(' ');
                for (int j = 0; j < 8; j++)
                {
                    mass[i, j] = read[j];
                }
            }
            Console.WriteLine("1. Вывести данные на экран. \n " +
                "2. Удалить строку. \n" +
                "3. Изменить строку. \n" +
                "4. Сохранить и завершить работу. \n");
            Console.WriteLine("Введите номер команды -> ");
            int comand = Convert.ToInt32(Console.ReadLine());
            switch (comand)
            {
                case 1:
                    {
                        for(int i = 0; i < x; i ++)
                        {
                            Console.WriteLine(mass[i, 1] + "   " + mass[i, 2] + "   " + mass[i, 3] + "   " + mass[i, 4] + "   " + mass[i, 5] + "   " + mass[i, 6] + "   " + mass[i, 7] + "   " + mass[i, 8]);
                            Console.WriteLine("\n");
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Введите номер строки, которую нужно удалить -> ");
                        int num = Convert.ToInt32
                    }
                case 3:
                case 4:
                    

                    
                default:
            }
        }
    }
}

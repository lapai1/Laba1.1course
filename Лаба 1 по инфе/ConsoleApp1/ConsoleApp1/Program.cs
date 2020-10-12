using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file name as C:/file.txt :");

            int[] array1v1;
            string[] _lines = System.IO.File.ReadAllLines(@"C:\Users\Даниил\Desktop\Лаба 1 по инфе\lala.txt");
            List<int> A_list = new List<int>();

            foreach (var _line in _lines)
            {
                A_list.Add(int.Parse(_line));
            }

            array1v1 = A_list.ToArray();

            Console.Write("Array:");
            for (int i = 0; i < array1v1.Length; i++)
            {
                Console.Write(array1v1[i] + " ");
            }
            Console.ReadLine();



        }

    }
}
    

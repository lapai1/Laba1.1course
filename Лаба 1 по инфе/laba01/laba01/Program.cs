using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace laba01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                //Выбор типа работы(выбор массива (одномерный или двумерный или ступенчатый))
                //можно использовать "/n" но я забыл про этот литерал
                Console.WriteLine("Select the type of array to continue working with:");
            Console.WriteLine("\ta - One Dimensional Array");
            Console.WriteLine("\tb - One Dimensional Array with method");
            Console.WriteLine("\tc - Two Dimensional Array");
            Console.WriteLine("\td - Stepped Array");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                #region 1-D
                case "a":
                    {
                        
                        //Выбор задачи
                        Console.WriteLine("Selected task:");
                        Console.WriteLine("\ta - Output of array elements");
                        Console.WriteLine("\tb - Min and Max. Output value + number");
                        Console.WriteLine("\tc - Сarry out direct and reverse sorting");
                        Console.WriteLine("\td - Create a new array and fill it with even elements from the original one");
                        Console.Write("Your option? ");

                        switch (Console.ReadLine())
                        {

                            case "a":
                                
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");

                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        Console.Write("Enter the number of mass elements:");
                                        //cardinality - кол-во элементов
                                        //сделать инструкцию, как вводить элементы массива
                                        int cardinality1 = int.Parse(Console.ReadLine());
                                        int[] array1 = new int[cardinality1];
                                        for (int i = 0; i < array1.Length; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array1[i] = int.Parse(Console.ReadLine());
                                        }
                                        Console.Write("Array:");
                                        for (int i = 0; i < array1.Length; i++)
                                        {
                                            Console.Write(array1[i] + " ");
                                        }
                                        Console.ReadLine();
                                        break;          
                                    case "m":
                                        // варивнт ввода пути файла с клавиатуры
                                        //string path = Console.ReadLine();
                                        //string[] _lines = System.IO.File.ReadAllLines(@path);

                                        int[] array1v1;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
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
                                        break;
                                }
                                break;
                            case "b":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int n = int.Parse(Console.ReadLine());
                                        int[] array2 = new int[n];
                                        for (int i = 0; i < n; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array2[i] = int.Parse(Console.ReadLine());
                                        }

                                        int min = int.MaxValue;
                                        int max = int.MinValue;

                                            // ДОБАВИТЬ НОМЕР ЭЛЕМЕНТА МАССИВА НА ВЫВОДЕ MIN and MAX
                                        int posMax = 1;
                                        int posMin = 1;
                                        for (int i = 0; i < array2.Length; i++)
                                        {

                                            if (array2[i] < min)
                                            {
                                                min = array2[i];
                                                posMin = i+1;
                                            }
                                            if (array2[i] > max)
                                            {
                                                max = array2[i];
                                                posMax = i+1;
                                            }
                                        }

                                        Console.WriteLine("Min:" + min + " " + "El number:" + posMin);
                                        Console.WriteLine("Max:" + max + " " + "El number:" + posMax);
                                        break;
                                    case "m":
                                        int[] array2v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();

                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }

                                        array2v2 = A_list.ToArray();


                                        int min1 = int.MaxValue;
                                        int max1 = int.MinValue;
                                        int posMax1 = 1;
                                        int posMin1 = 1;
                                        // ДОБАВИТЬ НОМЕР ЭЛЕМЕНТА МАССИВА НА ВЫВОДЕ MIN and MAX
                                        for (int i = 0; i < array2v2.Length; i++)
                                        {
                                            if (array2v2[i] < min1)
                                            {
                                                min1 = array2v2[i];
                                                posMin1 = i+1;
                                            }
                                            if (array2v2[i] > max1)
                                            {
                                                max1 = array2v2[i];
                                                posMax1 = i+1;
                                            }
                                        }   
                                        Console.WriteLine("Min:" + min1 + " " + "El number:" + posMin1);
                                        Console.WriteLine("Max:" + max1 + " " + "El number:" + posMax1);
                                        break;
                                }
                                break;
                                
                            case "c":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int с = int.Parse(Console.ReadLine());
                                        int[] array3 = new int[с];
                                        for (int i = 0; i < с; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array3[i] = int.Parse(Console.ReadLine());
                                        }
                                        //прямая сортировка
                                        int temp;
                                        for (int i = 0; i < array3.Length; i++)
                                        {
                                            for (int j = i; j < array3.Length; j++)
                                            {
                                                if (array3[i] > array3[j])
                                                {
                                                    temp = array3[i];
                                                    array3[i] = array3[j];
                                                    array3[j] = temp;
                                                }
                                            }
                                        }
                                        Console.Write("Direct sorting:");
                                        for (int i = 0; i < array3.Length; i++)
                                        {
                                            Console.Write(array3[i] + " ");
                                        }
                                        Console.ReadLine();
                                        //обратная сортировка
                                        int temp1;
                                        for (int i = 0; i < array3.Length; i++)
                                        {
                                            for (int j = i; j < array3.Length; j++)
                                            {
                                                if (array3[i] < array3[j])
                                                {
                                                    temp1 = array3[i];
                                                    array3[i] = array3[j];
                                                    array3[j] = temp1;
                                                }
                                            }
                                        }
                                        // вывод обратноотсортированного массива
                                        Console.Write("Reverse sorting:");
                                        for (int i = 0; i < array3.Length; i++)
                                        {
                                            Console.Write(array3[i] + " ");
                                        }
                                        Console.ReadLine();

                                        break;
                                    case "m":
                                        int[] array3v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();

                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }

                                        array3v2 = A_list.ToArray();
                                        //прямая сортировка
                                        int tempv1;
                                        for (int i = 0; i < array3v2.Length; i++)
                                        {
                                            for (int j = i; j < array3v2.Length; j++)
                                            {
                                                if (array3v2[i] > array3v2[j])
                                                {
                                                    tempv1 = array3v2[i];
                                                    array3v2[i] = array3v2[j];
                                                    array3v2[j] = tempv1;
                                                }
                                            }
                                        }
                                        Console.Write("Direct sorting:");
                                        for (int i = 0; i < array3v2.Length; i++)
                                        {
                                            Console.Write(array3v2[i] + " ");
                                        }
                                        Console.ReadLine();
                                        //обратная сортировка
                                        int temp1v1;
                                        for (int i = 0; i < array3v2.Length; i++)
                                        {
                                            for (int j = i; j < array3v2.Length; j++)
                                            {
                                                if (array3v2[i] < array3v2[j])
                                                {
                                                    temp1v1 = array3v2[i];
                                                    array3v2[i] = array3v2[j];
                                                    array3v2[j] = temp1v1;
                                                }
                                            }
                                        }
                                        // вывод обратноотсортированного массива
                                        Console.Write("Reverse sorting:");
                                        for (int i = 0; i < array3v2.Length; i++)
                                        {
                                            Console.Write(array3v2[i] + " ");
                                        }
                                        Console.ReadLine();


                                        break;
                                }
                                break;
                            case "d":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        // Создать новый массив и заполнить его четными элементами из исходного
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int q = int.Parse(Console.ReadLine());
                                        int[] array4 = new int[q];
                                        for (int i = 0; i < q; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array4[i] = int.Parse(Console.ReadLine());
                                        }
                                        // even - четный 
                                        int even = 0;
                                        // написать подсчет четных чисел в массиве и записать в even

                                        for (int i = 0; i < array4.Length; i++)
                                        {
                                            if (array4[i] % 2 == 0)
                                            {
                                                //если есть четное число, то увеличиваем even на 1, тем самым увеличиваем array5 на кол-во эл-ов
                                                even++;
                                            }
                                        }
                                        int[] array5 = new int[even]; // новый массив размером с количество even
                                        int index = 0; // новая переменная которая будет хранить текущий индекс второго массива 
                                        for (int i = 0; i < array4.Length; i++)
                                        {
                                            if (array4[i] % 2 == 0)
                                            {
                                                array5[index] = array4[i];
                                                index++;
                                            }
                                        }
                                        Console.WriteLine("Array with even elements of the original array");
                                        for (int i = 0; i < array5.Length; i++)
                                        {
                                            Console.WriteLine(array5[i] + " ");
                                        }
                                        Console.ReadLine();
                                        break;
                                    case "m":
                                        int[] array4v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();

                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }

                                        array4v2 = A_list.ToArray();

                                        // even - четный 
                                        int even1 = 0;
                                        // написать подсчет четных чисел в массиве и записать в even

                                        for (int i = 0; i < array4v2.Length; i++)
                                        {
                                            if (array4v2[i] % 2 == 0)
                                            {
                                                //если есть четное число, то увеличиваем even на 1, тем самым увеличиваем array5 на кол-во эл-ов
                                                even1++;
                                            }
                                        }
                                        int[] array5v2 = new int[even1]; // новый массив размером с количество even
                                        int index1 = 0; // новая переменная которая будет хранить текущий индекс второго массива 
                                        for (int i = 0; i < array4v2.Length; i++)
                                        {
                                            if (array4v2[i] % 2 == 0)
                                            {
                                                array5v2[index1] = array4v2[i];
                                                index1++;
                                            }
                                        }
                                        Console.WriteLine("Array with even elements of the original array");
                                        for (int i = 0; i < array5v2.Length; i++)
                                        {
                                            Console.WriteLine(array5v2[i] + " ");
                                        }
                                        Console.ReadLine();
                                        break;
                                            }
                                break;
                        }
                        break;
                    }
                #endregion 1-D


                #region 1-D System.Array
                case "b":
                    {
                        //Выбор задачи
                        Console.WriteLine("Selected task:");
                        Console.WriteLine("\ta - Output of array elements");
                        Console.WriteLine("\tb - Min and Max. Output value + number");
                        Console.WriteLine("\tc - Сarry out direct and reverse sorting");
                        Console.WriteLine("\td - Create a new array and fill it with even elements from the original one");
                        Console.Write("Your option? ");

                        switch (Console.ReadLine())
                        {
                            case "a":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        //Вывод элементов массива
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int f = int.Parse(Console.ReadLine());
                                        int[] array16 = new int[f];
                                        for (int i = 0; i < f; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array16[i] = int.Parse(Console.ReadLine());
                                        }
                                        Console.Write("Array:");
                                        foreach (int number in array16)
                                        {
                                            Console.Write($"{number} \t");
                                        }
                                        break;
                                    case "m":
                                        int[] array16v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();

                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }
                                        array16v2 = A_list.ToArray();
                                        Console.Write("Array:");
                                        foreach (int number in array16v2)
                                        {
                                            Console.Write($"{number} \t");
                                        }
                                        break;
                                }
                                break;
                            case "b":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int n = int.Parse(Console.ReadLine());
                                        int[] array2 = new int[n];
                                        for (int i = 0; i < n; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array2[i] = int.Parse(Console.ReadLine());
                                        }

                                        int min = int.MaxValue;
                                        int max = int.MinValue;
                                        int posMin = 1;
                                        int posMax = 1;

                                        // ДОБАВИТЬ НОМЕР ЭЛЕМЕНТА МАССИВА НА ВЫВОДЕ MIN and MAX
                                            for (int i = 0; i < array2.Length; i++)
                                        {
                                            if (array2[i] < min)
                                            {
                                                min = array2[i];
                                                posMin = i+1;
                                            }
                                            if (array2[i] > max)
                                            {
                                                max = array2[i];
                                                posMax = i+1;
                                            }
                                        }
                                        Console.Write("Min:" + min + " " + "El number:" + posMin);
                                        Console.Write("Max:" + max + " " + "El number:" + posMax);
                                        break;
                                    case "m":
                                        int[] array2v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();
                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }
                                        array2v2 = A_list.ToArray();
                                        int min1 = int.MaxValue;
                                        int max1 = int.MinValue;
                                        int posMin1 = 1;
                                        int posMax1 = 1;
                                        // ДОБАВИТЬ НОМЕР ЭЛЕМЕНТА МАССИВА НА ВЫВОДЕ MIN and MAX
                                        for (int i = 0; i < array2v2.Length; i++)
                                        {
                                            if (array2v2[i] < min1)
                                            {
                                                min1 = array2v2[i];
                                                posMin1 = 1+1;
                                            }
                                            if (array2v2[i] > max1)
                                            {
                                                max1 = array2v2[i];
                                                posMax1 = i+1;
                                            }
                                        }
                                        Console.WriteLine("Min:" + min1 + " " + "El number:" + posMin1);
                                        Console.WriteLine("Max:" + max1 + " " + "El number:" + posMin1);
                                        break;
                                }
                                break;

                            case "c":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        //Выполнить прямую и обратную сортировку!
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int b = int.Parse(Console.ReadLine());
                                        int[] array15 = new int[b];
                                        for (int i = 0; i < b; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array15[i] = int.Parse(Console.ReadLine());
                                        }
                                        Console.Write("Direct sorting:");
                                        Array.Sort(array15);
                                        foreach (int number in array15)
                                        {
                                            Console.Write($"{number} \t");
                                        }
                                        Console.Write("Reverse sorting:");
                                        Array.Reverse(array15);
                                        foreach (int number in array15)
                                        {
                                            Console.Write($"{number} \t");
                                        }
                                        break;
                                    case "m":
                                        int[] array15v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();
                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }
                                        array15v2 = A_list.ToArray();
                                        Console.Write("Direct sorting:");
                                        Array.Sort(array15v2);
                                        foreach (int number in array15v2)
                                        {
                                            Console.Write($"{number} \t");
                                        }
                                        Console.Write("Reverse sorting:");
                                        Array.Reverse(array15v2);
                                        foreach (int number in array15v2)
                                        {
                                            Console.Write($"{number} \t");
                                        }
                                        break;
                                }
                                break;
                            case "d":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        Console.WriteLine("Enter the number of mass elements:");
                                        int c = int.Parse(Console.ReadLine());
                                        int[] array17 = new int[c];
                                        for (int i = 0; i < c; i++)
                                        {
                                            Console.WriteLine("Enter {0}-й element", i + 1);
                                            array17[i] = int.Parse(Console.ReadLine());
                                        }
                                        CreateEvenSystemArray(array17);
                                        static void CreateEvenSystemArray(int[] array)
                                        {
                                            int length = 0;
                                            Array.ForEach(array, (i) =>
                                            {
                                                if (i % 2 == 0) length++;
                                            });
                                            int[] arr_ = new int[length];
                                            for (int i = 0, k = 0; i < length; i++)
                                            {
                                                if (array[i] % 2 == 0) arr_[k++] = array[i];
                                            }
                                            Console.WriteLine("Array with even value:");
                                            for (int i = 0; i < arr_.Length; i++)
                                            {
                                                Console.Write(arr_[i] + " ");
                                            }
                                            //Исправитть вывод!!!
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "m":
                                        int[] array17v2;
                                        string[] _lines = System.IO.File.ReadAllLines(@"C:\lala.txt");
                                        List<int> A_list = new List<int>();
                                        foreach (var _line in _lines)
                                        {
                                            A_list.Add(int.Parse(_line));
                                        }
                                        array17v2 = A_list.ToArray();
                                        CreateEvenSystemArray1(array17v2);
                                        static void CreateEvenSystemArray1(int[] array)
                                        {
                                            int length = 0;

                                            Array.ForEach(array, (i) =>
                                            {
                                                if (i % 2 == 0) length++;
                                            });

                                            int[] arr_ = new int[length];

                                            for (int i = 0, k = 0; k < length; i++)
                                            {
                                                if (array[i] % 2 == 0) arr_[k++] = array[i];
                                            }
                                            Console.WriteLine("Array with even value:");
                                            for (int i = 0; i < arr_.Length; i++)
                                            {
                                                Console.Write(arr_[i] + " ");
                                            }
                                        }
                                            break;
                                }
                                break;
                        }
                        break;
                    }
                #endregion 1-D System.Array


                #region 2-D
                case "c":
                    {
                        //Выбор задачи
                        Console.WriteLine("Selected task:");
                        Console.WriteLine("\ta - Output of array elements");
                        Console.WriteLine("\tb - Min and Max. Output value + number");
                        Console.WriteLine("\tc - Perform the product, sum, and difference of 2 parts of the array");
                        Console.Write("Your option? ");

                        switch (Console.ReadLine())
                        {
                            case "a":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        //Вывод элементов массива!
                                        // y отвечает за высоту
                                        // x отвечает за ширину
                                        // ps это не принципиально важно, но для чтения кода и понимания - удобно!
                                        Console.Write("Enter the lines: ");
                                        int x = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the columns: ");
                                        int y = int.Parse(Console.ReadLine());
                                        int[,] array7 = new int[x, y];
                                        Console.WriteLine();
                                        for (int i = 0; i < x; i++)
                                        {
                                            Console.WriteLine("Enter elements {0} array", i + 1);

                                            for (int j = 0; j < y; j++)
                                            {
                                                array7[i, j] = int.Parse(Console.ReadLine());

                                            }
                                        }
                                        Console.WriteLine("Your array:");
                                        for (int row = 0; row < array7.GetLength(0); row++)
                                        {
                                            for (int col = 0;  col < array7.GetLength(1); col++)
                                                Console.Write(array7[row, col] + " ");
                                            Console.WriteLine();

                                        }
                                        break;
                                    case "m":
                                        string[] lines = System.IO.File.ReadAllLines(@"C:\lala1.txt");
                                        int[,] array7v2 = new int[lines.Length, lines[0].Split(' ').Length];
                                        for (int i = 0; i < lines.Length; i++)
                                        {
                                            string[] temp = lines[i].Split(' ');
                                            for (int j = 0; j < temp.Length; j++)
                                                array7v2[i, j] = Convert.ToInt32(temp[j]);
                                        }
                                        Console.WriteLine("Your array:");
                                        for (int row = 0; row < array7v2.GetLength(0); row++)
                                        {
                                            for (int col1 = 0; col1 < array7v2.GetLength(1); col1++)
                                                Console.Write(array7v2[row, col1] + " ");
                                            Console.WriteLine();
                                        }

                                            break;
                                }
                                break;
                            case "b":Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        //Min и Max. Вывести значение + номер(учесть что +1 тк начинается с 0)
                                        Console.Write("Enter the lines: ");
                                        int z = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the columns: ");
                                        int e = int.Parse(Console.ReadLine());
                                        int[,] array8 = new int[z, e];
                                        Console.WriteLine();
                                        for (int i = 0; i < z; i++)
                                        {
                                            Console.WriteLine("Enter elements {0} array", i + 1);
                                            for (int j = 0; j < e; j++)
                                            {
                                                array8[i, j] = int.Parse(Console.ReadLine());
                                            }
                                        }
                                        int min = array8[0, 0];
                                        int max = array8[0, 0];
                                        int posMax = 1;
                                        int posMax1 = 1;
                                        int posMin = 1;
                                        int posMin1 = 1;
                                        for (int i = 0; i < z; i++)
                                        {
                                            for (int j = 0; j < e; j++)
                                            {
                                                if (array8[i, j] > max)
                                                    {
                                                        max = array8[i, j];
                                                        posMax = i+1;
                                                        posMax1 = j+1;
                                                    }
                                                if (array8[i, j] < min)
                                                    {
                                                        min = array8[i, j];
                                                        posMin = i + 1;
                                                        posMin1 = j + 1;
                                                    }
                                            }
                                        }
                                            // поправить вывод - циклится !
                                        Console.WriteLine("Min:" + min + " " + "El number:" + posMin + ";" + posMin1);
                                        Console.WriteLine("Max:" + max + " " + "El number:" + posMax + ";" + posMax1);
                                            break;
                                    case "m":
                                        string[] lines = System.IO.File.ReadAllLines(@"C:\lala1.txt");
                                        int[,] array8v2 = new int[lines.Length, lines[0].Split(' ').Length];
                                        for (int i = 0; i < lines.Length; i++)
                                        {
                                            string[] temp = lines[i].Split(' ');
                                            for (int j = 0; j < temp.Length; j++)
                                                array8v2[i, j] = Convert.ToInt32(temp[j]);
                                        }
                                        int z1 = lines.Length;
                                        int e1 = lines[0].Split(' ').Length;
                                        int min1 = array8v2[0, 0];
                                        int max1 = array8v2[0, 0];
                                        int posMax4 = 1;
                                        int posMax3 = 1;
                                        int posMin4 = 1;
                                        int posMin3 = 1;
                                        for (int i = 0; i < z1; i++)
                                        {
                                            for (int j = 0; j < e1; j++)
                                            {
                                                    if (array8v2[i, j] > max1)
                                                    {
                                                        max1 = array8v2[i, j];
                                                        posMax4 = i + 1;
                                                        posMax3 = j + 1;
                                                    }
                                                    if (array8v2[i, j] < min1)
                                                    {
                                                        min1 = array8v2[i, j];
                                                        posMin4 = i + 1;
                                                        posMin3 = j + 1;
                                                    }
                                            }
                                        }
                                        Console.WriteLine("Min:" + min1 + " " + "El number:" + posMin4 + ";" + posMin3);
                                        Console.WriteLine("Max:" + max1 + " " + "El number:" + posMax4 + ";" + posMax3) ;
                                        break;
                                }
                                break;
                            case "c":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        //Выполнить произведение, сумму и разницу 2 частей массива
                                        Console.Write("Enter the lines of 1 array: ");
                                        int f = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the columns of 1 array: ");
                                        int d = int.Parse(Console.ReadLine());
                                        int[,] array9 = new int[f, d];
                                        Console.WriteLine();
                                        int g, p;
                                        for (int i = 0; i < f; i++)
                                        {
                                            Console.WriteLine("Enter elements {0} array", i + 1);
                                            for (int j = 0; j < d; j++)
                                            {
                                                array9[i, j] = int.Parse(Console.ReadLine());
                                            }
                                        }
                                        Console.Write("Enter the lines of 1 array: ");
                                        int h = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the columns of 1 array: ");
                                        int q = int.Parse(Console.ReadLine());
                                        int[,] array10 = new int[f, d];
                                        Console.WriteLine();
                                        for (int i = 0; i < h; i++)
                                        {
                                            Console.WriteLine("Enter elements {0} array", i + 1);
                                            for (int j = 0; j < q; j++)
                                            {
                                                array10[i, j] = int.Parse(Console.ReadLine());
                                            }
                                        }
                                        Console.WriteLine("BiBERI RIAD 1st array");
                                        int a = int.Parse(Console.ReadLine());
                                        Console.WriteLine("BiBERI SROKY 1st array");
                                        int b = int.Parse(Console.ReadLine());
                                        Console.WriteLine("BiBERI RIAD 2st array");
                                        int a1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("BiBERI SROKY 2st array");
                                        int b1 = int.Parse(Console.ReadLine());
                                        // далее идет вывод этого элемента, можно урезать в последствии
                                        Console.WriteLine("Multiplication");
                                        Console.WriteLine(array9[a, b] * array10[b1, a1]);
                                        Console.WriteLine("Аmount");
                                        Console.WriteLine(array9[a, b] + array10[b1, a1]);
                                        Console.WriteLine("Difference");
                                        Console.WriteLine(array9[a, b] - array10[b1, a1]);
                                        Console.ReadKey();
                                        break;
                                    case "m":
                                        string[] lines = System.IO.File.ReadAllLines(@"C:\lala1.txt");
                                        int[,] array9v2 = new int[lines.Length, lines[0].Split(' ').Length];
                                        for (int i = 0; i < lines.Length; i++)
                                        {
                                            string[] temp = lines[i].Split(' ');
                                            for (int j = 0; j < temp.Length; j++)
                                                array9v2[i, j] = Convert.ToInt32(temp[j]);
                                        }
                                        string[] lines1 = System.IO.File.ReadAllLines(@"C:\lala3.txt");
                                        int[,] array10v2 = new int[lines.Length, lines[0].Split(' ').Length];
                                        for (int i = 0; i < lines.Length; i++)
                                        {
                                            string[] temp = lines1[i].Split(' ');
                                            for (int j = 0; j < temp.Length; j++)
                                                array10v2[i, j] = Convert.ToInt32(temp[j]);
                                        }
                                        Console.WriteLine("BiBERI RIAD 1st array * el number start by 0 ");
                                        int a2 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("BiBERI SROKY 1st array * el number start by 0");
                                        int b2 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("BiBERI RIAD 2st array * el number start by 0");
                                        int a3 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("BiBERI SROKY 2st array * el number start by 0");
                                        int b3 = int.Parse(Console.ReadLine());
                                        // далее идет вывод этого элемента, можно урезать в последствии
                                        Console.WriteLine("Multiplication");
                                        Console.WriteLine(array9v2[a2, b2] * array10v2[b3, a3]);
                                        Console.WriteLine("Аmount");
                                        Console.WriteLine(array9v2[a2, b2] + array10v2[b3, a3]);
                                        Console.WriteLine("Difference");
                                        Console.WriteLine(array9v2[a2, b2] - array10v2[b3, a3]);
                                        Console.ReadKey();
                                        // сначала допилить в вводе с клавиатуры, потом перенести сюда....
                                        break;
                                }
                                break;         
                        }
                        break;
                    }
                #endregion 2-D


                #region Step

                case "d":
                    {
                        //Выбор задачи
                        Console.WriteLine("Selected task:");
                        Console.WriteLine("\ta - Output of array elements and Min and Max");
                        Console.WriteLine("\tb - Edit array");
                        Console.Write("Your option? ");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        //Вывод элементов массива
                                        int max = int.MinValue;
                                        int min = int.MaxValue;
                                        Console.WriteLine("Enter the lines: ");
                                        int m = Convert.ToInt32(Console.ReadLine());
                                        int[][] array11 = new int[m][];
                                        int posMax = 1;
                                        int posMax1 = 1;
                                        int posMin = 1;
                                        int posMin1 = 1;
                                        for (int i = 0; i < m; i++)
                                        {
                                            Console.WriteLine($"Enter elements {i + 1} array");
                                            string[] str = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
                                            array11[i] = new int[str.Length];

                                            for (int j = 0; j < str.Length; j++)
                                            {
                                                array11[i][j] = Convert.ToInt32(str[j]);
                                            }
                                            
                                            for (int q = 0; q < str.Length; q++)
                                            {
                                                if (array11[i][q] > max)
                                                {
                                                    max = array11[i][q];
                                                    posMax = i+1;
                                                    posMax1 = q+1;
                                                }
                                                if (array11[i][q] < min)
                                                {
                                                    min = array11[i][q];
                                                    posMin = i+1;
                                                    posMin1 = q+1;
                                                }
                                            }
                                        
                                        }
                                        Console.WriteLine("Min and Max:");
                                        Console.WriteLine("Min:" + min + " " + "El number:" + posMin + ";" + posMin1);
                                        Console.WriteLine("Max:" + max + " " + "El number:" + posMax + ";" + posMax1) ;
                                        Console.WriteLine("Your array:");
                                        foreach (int[] row in array11)
                                        {
                                            foreach (int number in row)
                                            {
                                                Console.Write($"{number} \t");
                                            }
                                            Console.WriteLine();
                                        }
                                        break;
                                    case "m":
                                        int max1 = int.MinValue;
                                        int min1 = int.MaxValue;
                                        int c = 0;
                                        StreamReader b = new StreamReader(@"C:\lala2.txt");
                                        c = File.ReadAllLines(@"C:\lala2.txt").Length;
                                        int[][] array11v2 = new int[c][];
                                        string[] s = new string[0]; 
                                        int posMax2 = 1;
                                        int posMax3 = 1;
                                        int posMin2 = 1;
                                        int posMin3 = 1;
                                        for (int i = 0; i < c; i++)
                                        {
                                            s = new string[0];
                                            array11v2[i] = new int[s.Length];
                                            s = b.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
                                            array11v2[i] = new int[s.Length];
                                            for (int j1 = 0; j1 < s.Length; j1++)
                                            {
                                                array11v2[i][j1] = Convert.ToInt32(s[j1]);
                                            }
                                            
                                            for (int q = 0; q < s.Length; q++)
                                            {
                                                if (array11v2[i][q] > max1)
                                                {
                                                    max1 = array11v2[i][q];
                                                    posMax2 = i+1;
                                                    posMax3 = q+1;
                                                }
                                                if (array11v2[i][q] < min1)
                                                {
                                                    min1 = array11v2[i][q];
                                                    posMin2 = i+1;
                                                    posMin3 = q+1;
                                                }
                                            }
                                            
                                        }
                                        Console.WriteLine("Min and Max:");
                                        Console.WriteLine("Min:" + min1 + " " + "El number:" + posMin2 + ";" + posMin3);
                                        Console.WriteLine("Max:" + max1 + " " + "El number:" + posMax2 + ";" + posMax3) ;
                                        Console.WriteLine("Your array:");
                                        foreach (int [] vin in array11v2)
                                        {
                                            foreach (int numbers1 in vin)
                                            {
                                                Console.Write($"{numbers1} \t");
                                            }
                                            Console.WriteLine();
                                        }
                                        
                                        break;
                                }
                                break;
                            case "b":
                                Console.WriteLine("\tn - Keyboard");
                                Console.WriteLine("\tm - File on work spase LABA 1 => lala.txt");
                                Console.Write("Your option? ");
                                switch (Console.ReadLine())
                                {
                                    case "n":
                                        // изменить массив 
                                        Console.WriteLine("Enter the lines: ");
                                        int c = Convert.ToInt32(Console.ReadLine());
                                        int[][] array12 = new int[c][];
                                        for (int i = 0; i < c; i++)
                                        {
                                            Console.WriteLine($"Enter elements {i + 1} array");
                                            string[] str = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);

                                            array12[i] = new int[str.Length];
                                            for (int j = 0; j < str.Length; j++)
                                            {
                                                array12[i][j] = Convert.ToInt32(str[j]);
                                            }
                                        }
                                        // уже ввели массив!
                                        Console.WriteLine("Which {0} array elements do you want to change?", c);
                                        int nor = Convert.ToInt32(Console.ReadLine()) - 1;
                                        Console.WriteLine("Enter number element(<{0}):", array12[nor].Length);
                                        int nor1 = Convert.ToInt32(Console.ReadLine()) - 1;
                                        Console.WriteLine("Enter number for change:");
                                        array12[nor][nor1] = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Changed array:");
                                        foreach (int[] row in array12)
                                        {
                                            foreach (int number in row)
                                            {
                                                Console.Write($"{number} \t");
                                            }
                                            Console.WriteLine();
                                        }
                                        break;
                                    case "m":
                                        int c1 = 0;
                                        StreamReader b = new StreamReader(@"C:\lala2.txt");
                                        c1 = File.ReadAllLines(@"C:\lala2.txt").Length;
                                        int[][] array12v2 = new int[c1][];
                                        string[] s = new string[0];
                                        for (int i = 0; i < c1; i++)
                                        {
                                            s = new string[0];
                                            array12v2[i] = new int[s.Length];
                                            s = b.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
                                            array12v2[i] = new int[s.Length];
                                            for (int j1 = 0; j1 < s.Length; j1++)
                                            {
                                                array12v2[i][j1] = Convert.ToInt32(s[j1]);
                                            }
                                        }
                                        Console.WriteLine("Which {0} array elements do you want to change?", c1);
                                        int nor2 = Convert.ToInt32(Console.ReadLine()) - 1;
                                        Console.WriteLine("Enter number element(<{0}):", array12v2[nor2].Length);
                                        int nor3 = Convert.ToInt32(Console.ReadLine()) - 1;
                                        Console.WriteLine("Enter number for change:");
                                        array12v2[nor2][nor3] = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Changed array:");
                                        foreach (int[] row in array12v2)
                                        {
                                            foreach (int number in row)
                                            {
                                                Console.Write($"{number} \t");
                                            }
                                            Console.WriteLine();
                                        }
                                        break;
                                }
                                break;
                        }

                    }
                    break;
                    
                 #endregion Step

            }
                Console.WriteLine("Повторить? y/n");
                if (Console.ReadKey(true).Key != ConsoleKey.Y)
                    break;
            }
    }
}
}

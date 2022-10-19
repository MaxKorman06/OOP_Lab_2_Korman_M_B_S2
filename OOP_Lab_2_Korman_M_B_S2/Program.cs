using System;
using System.Collections.Generic;

namespace OOP_Lab_2_Korman_M_B_S2
{
    class Program
    {
        static int wrld_arr(string str)
        {
            int wrld = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i - 1] == 'A' || str[i - 1] == 'a' || str[i - 1] == 'E' || str[i - 1] == 'e' || str[i - 1] == 'U' || str[i - 1] == 'u' || 
                     str[i - 1] == 'I' || str[i - 1] == 'i' || str[i - 1] == 'O' || str[i - 1] == 'o' || str[i - 1] == 'У' || str[i - 1] == 'у' || 
                     str[i - 1] == 'Е' || str[i - 1] == 'е' || str[i - 1] == 'І' || str[i - 1] == 'і' || str[i - 1] == 'А' || str[i - 1] == 'а' || 
                     str[i - 1] == 'О' || str[i - 1] == 'о' || str[i - 1] == 'Є' || str[i - 1] == 'є' || str[i - 1] == 'Я' || str[i - 1] == 'я' || 
                     str[i - 1] == 'Ю' || str[i - 1] == 'ю') && str[i] == ' ')
                {
                    ++wrld;
                }
            }
            return wrld;
        }
        static string cut_string(string str)
        {
            String sim5_str = "";
            String sim5_str_h = "";
            int str_count = 0;
            for (int i = 1; i < str.Length; i++)
            {   
                if (str_count > 5)
                {
                    sim5_str_h = "";
                    str_count = 0;
                }
                if (str[i - 1] == ' ' && str_count <= 5 && str_count > 0)
                {
                    sim5_str += sim5_str_h;
                    sim5_str_h = "";
                    str_count = 0;
                }
                
                sim5_str_h += str[i - 1];
                str_count++;
            }
            return sim5_str;
        }
        static void pushZerosToEnd(double[] arr)
        {
            int n = arr.Length;
            // Count of non-zero elements
            int count = 0;

            // Traverse the array. If element encountered is
            // non-zero, then replace the element
            // at index â..countâ.. with this element
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    // here count is incremented
                    arr[count++] = arr[i];
                }
            }

            // Now all non-zero elements have been shifted to
            // front and â..countâ.. is set as index of first 0.
            // Make all elements 0 from count to end.
            while (count < n)
            {
                arr[count++] = 0;
            }
        }
        static void pushOnesToEnd(double[] arr)
        {
            int n = arr.Length;
            // Count of non-zero elements
            int count = 0;

            // Traverse the array. If element encountered is
            // non-zero, then replace the element
            // at index â..countâ.. with this element
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 1)
                {
                    // here count is incremented
                    arr[count++] = arr[i];
                }
            }

            // Now all non-zero elements have been shifted to
            // front and â..countâ.. is set as index of first 0.
            // Make all elements 0 from count to end.
            while (count < n)
            {
                arr[count++] = 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Яке завдання бажаєте виконати?\nЗавдання 1?\nЗавдання 2?\nЗавдання 3?\nЗавдання 4?");
            int count = Convert.ToInt32(Console.ReadLine());

            switch (count)
            {
                case 1:
                    // Завдання 1
                    {
                        Console.WriteLine("Бажаєте ввикорстовувати стандартні значення масиву чи ввести його?\n1 = Ввести його самотушки\t0 = Використовувати стандартні значення");
                        int arr_cize = Convert.ToInt32(Console.ReadLine());

                        int row = 5, col = 5;
                        double[,] arr = new double[row, col];

                        if (arr_cize == 1)
                        {
                            Console.Write("Введіть кількість рядків масиву: ");
                            row = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть кількість рядків масиву:");
                            col = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Вводьте масив розміру" + row + "на" + col);
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < col; j++)
                                {
                                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Використано масив станодартного розміру і значення");
                            arr[0, 0] = 1;  arr[1, 0] = 1.1;  arr[2, 0] = 0;    arr[3, 0] = 1.3;  arr[4, 0] = 1.4;
                            arr[0, 1] = -2; arr[1, 1] = 1.9;  arr[2, 1] = 1.8;  arr[3, 1] = 1.7;  arr[4, 1] = 1.6;
                            arr[0, 2] = 1;  arr[1, 2] = -1.1; arr[2, 2] = -1.2; arr[3, 2] = -1.3; arr[4, 2] = -1.4;
                            arr[0, 3] = -2; arr[1, 3] = 0;    arr[2, 3] = -1.8; arr[3, 3] = 0;    arr[4, 3] = -1.6;
                            arr[0, 4] = 0;  arr[1, 4] = 0.1;  arr[2, 4] = -0.1; arr[3, 4] = 0.2;  arr[4, 4] = -0.2;
                        }
                        double max = 0;
                        double sum = 0;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                if (max < Math.Abs(arr[i, j]))
                                {
                                    max = Math.Abs(arr[i, j]);
                                }
                            }
                        }
                        int counter = 0;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                if (arr[i, j] > 0)
                                {
                                    sum += arr[i, j];
                                    counter++;
                                }
                            }
                            if (counter == 2)
                            {
                                break;
                            }
                        }

                        double[] arr_h = new double[row * col];

                        int count_arr = 0;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                arr_h[count_arr] = arr[i, j];
                                count_arr++;
                            }
                        }

                        pushOnesToEnd(arr_h);
                        pushZerosToEnd(arr_h);

                        count_arr = 0;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                arr[i, j] = arr_h[count_arr];
                                count_arr++;
                            }
                        }

                        Console.WriteLine("Підпункт 1) " + max);
                        Console.WriteLine("Підпункт 2) " + sum);
                        Console.WriteLine("Підпункт 3) ");
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write(arr[i, j]);
                                Console.Write('\t');
                            }
                            Console.Write('\n');
                        }
                    }
                    break;
                case 2:
                    // Завдання 2
                    {
                        const int row = 3, col = 4;
                        double[][] digits = new double[col][];
                        digits[0] = new double[row] { 1, -3, 4 };
                        digits[1] = new double[row] { 2, 3, 1 };
                        digits[2] = new double[row] { 4, 2, 3 };
                        digits[3] = new double[row] { 0, -1, 0, };
                        
                        double[,] matrix = new double[row, col];

                        matrix[0, 0] = 1; matrix[1, 0] = -3; matrix[2, 0] = 4;
                        matrix[0, 1] = 2; matrix[1, 1] = 3;  matrix[2, 1] = 1;
                        matrix[0, 2] = 4; matrix[1, 2] = 2;  matrix[2, 2] = 3;
                        matrix[0, 3] = 0; matrix[1, 3] = -1; matrix[2, 3] = 0;

                        Console.WriteLine("Бажаєте ввикорстовувати стандартні значення масиву чи ввести його?\n1 = Ввести його самотушки\t0 = Використовувати стандартні значення");
                        int arr_cize = Convert.ToInt32(Console.ReadLine());
                        if (arr_cize == 1)
                        {
                            Console.WriteLine("Вводьте масив розміру" + row + "на" + col);
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < col; j++)
                                {
                                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                                }
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Використано масив станодартного розміру і значення");
                        }

                        //Метод Гауса 
                        double[,] clone_matrix_gaus = new double[3, 4];

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                clone_matrix_gaus[i, j] = matrix[i, j];
                            }
                        }

                        double a1;
                        double[] a = new double[2];

                        a1 = 1 / clone_matrix_gaus[0, 0];
                        a[0] = -clone_matrix_gaus[1, 0];
                        a[1] = -clone_matrix_gaus[2, 0];

                        for (int i = 0; i < 4; i++)
                        {
                            clone_matrix_gaus[0, i] = a1 * clone_matrix_gaus[0, i];
                        }

                        for (int j = 0; j < 2; j++)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                clone_matrix_gaus[j + 1, i] = clone_matrix_gaus[j + 1, i] + clone_matrix_gaus[0, i] * a[j];
                            }
                        }

                        double b1;
                        double[] b = new double[2];

                        b1 = 1 / clone_matrix_gaus[1, 1];
                        b[0] = -clone_matrix_gaus[0, 1];
                        b[1] = -clone_matrix_gaus[2, 1];

                        for (int i = 0; i < 4; i++)
                        {
                            clone_matrix_gaus[1, i] = b1 * clone_matrix_gaus[1, i];
                        }

                        for (int j = 0, l = 0; l < 2; j += 2, l++)
                        {
                            for (int i = 1; i < 4; i++)
                            {
                                clone_matrix_gaus[j, i] = clone_matrix_gaus[j, i] + clone_matrix_gaus[1, i] * b[l];
                            }
                        }

                        Console.WriteLine("Задана матриця");

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write(matrix[i, j]);
                                Console.Write('\t');
                            }
                            Console.Write('\n');
                        }

                        Console.WriteLine("Трикутна матриця");

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write(clone_matrix_gaus[i, j]);
                                Console.Write('\t');
                            }
                            Console.Write('\n');
                        }
                        
                        Console.WriteLine("Введіть значення за допомогою якого треба шукати кілкість радків менше заданої велечини");
                        double row_size_help = Convert.ToDouble(Console.ReadLine());
                        double row_size = 0;
                        double row_count = 0;
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                row_size += clone_matrix_gaus[i, j];
                            }
                            if (row_size < row_size_help)
                            {
                                row_count++;
                            }
                            row_size = 0;
                        }
                        Console.WriteLine("Кількість рядків менше заданої величини " + row_count);
                    }
                    break;
                case 3:
                    //Завдання 3
                    {
                        Console.WriteLine("Введіть текстовий рядок відповідно до умови");
                        string str;
                        str = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Кількість слів які закінчуються на голосну літеру: " + wrld_arr(str));
                        Console.WriteLine("Слова довжина яких менше 5-ти літер:" + cut_string(str));
                    }
                    break;
                case 4:
                    //Завдання 4
                    {
                        List<Tuple<string, int, string, double, double>> list = new List<Tuple<string, int, string, double, double>>
                        {
                             new Tuple<string, int, string, double, double>("Тернопіль", 1, "Чортків", 0.4, 88),
                             new Tuple<string, int, string, double, double>("Тернопіль", 3, "Збараж", 0.6, 100),
                             new Tuple<string, int, string, double, double>("Збараж", 2, "Тернопіль", 0.7, 110),
                             new Tuple<string, int, string, double, double>("Увисла", 4, "Тернопіль", 0.5, 95)
                        };
                        //list.Sort(Comparer<Tuple<string, int, string, double, double>>.Default);

                        int i = 0;
                        while (i != 6)
                        {
                            Console.WriteLine("Сортування за місцем віправлення: 1\nСортування за номером автобуса: 2\nСортування за місцем призначення: 3\nСортування за змнністю автобусса: 4\nСортування за ціною проїзду: 5\nВихід: 6");
                            i = Convert.ToInt32(Console.ReadLine());
                            switch (i)
                            {
                                case 1:
                                    {
                                        list.Sort((x, y) => x.Item1.CompareTo(y.Item1));
                                        list.ForEach(i => Console.Write("{0}\t", i));
                                    }
                                    break;
                                case 2:
                                    {
                                        list.Sort((x, y) => x.Item2.CompareTo(y.Item2));
                                        list.ForEach(i => Console.Write("{0}\t", i));
                                    }
                                    break;
                                case 3:
                                    {
                                        list.Sort((x, y) => x.Item3.CompareTo(y.Item3));
                                        list.ForEach(i => Console.Write("{0}\t", i));
                                    }
                                    break;
                                case 4:
                                    {
                                        list.Sort((x, y) => x.Item4.CompareTo(y.Item4));
                                        list.ForEach(i => Console.Write("{0}\t", i));
                                    }
                                    break;
                                case 5:
                                    {
                                        list.Sort((x, y) => x.Item5.CompareTo(y.Item5));
                                        list.ForEach(i => Console.Write("{0}\t", i));
                                    }
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("Невірне значення");
                                    break;
                            }
                            Console.WriteLine('\n');
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

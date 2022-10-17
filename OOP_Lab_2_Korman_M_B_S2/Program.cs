using System;

namespace OOP_Lab_2_Korman_M_B_S2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Яке завдання бажаєте виконати?\nЗавдання 1?\nЗавдання 2?\nЗавдання 3?");
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
                            arr[0, 0] = 1;  arr[1, 0] = 1.1;  arr[2, 0] = 1.2;  arr[3, 0] = 1.3;  arr[4, 0] = 1.4;
                            arr[0, 1] = -2; arr[1, 1] = 1.9;  arr[2, 1] = 1.8;  arr[3, 1] = 1.7;  arr[4, 1] = 1.6;
                            arr[0, 2] = 1;  arr[1, 2] = -1.1; arr[2, 2] = -1.2; arr[3, 2] = -1.3; arr[4, 2] = -1.4;
                            arr[0, 3] = -2; arr[1, 3] = -1.9; arr[2, 3] = -1.8; arr[3, 3] = -1.7; arr[4, 3] = -1.6;
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
                       
                    }
                    break;
                case 3:
                    //Завдання 3
                    {
                      
                    }
                    break;
                //Завдання 4
                case 4:
                    {

                    }
                    break;
                default:
                    break;
            }
        }
    }
}

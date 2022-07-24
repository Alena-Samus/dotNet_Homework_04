using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwless4
{
    class Program
    {
        static void Main(string[] args)
        {/*
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10

            int[] income = new int[] { 100_000, 120_000, 180_000, 70_000, 100_000, 200_000, 130_000, 150_000, 190_000, 110_000, 150_000, 100_000 }; //массив для хранения доходов
            int[] costs = new int[] { 80_000, 90_000, 70_000, 70_000, 80_000, 120_000, 140_000, 65_000, 90_000, 70_000, 120_000, 80_000 }; //массив для хранения расходов
            int[] profit = new int[12]; //массив для хранения прибыли
            int[] profitOld = new int[12]; //массив для хранения прибыли
            int[] badMonth = new int[3];

            int positiveProfit = 0;

            Random ramdom = new Random();

            //Ввод данных в массивы
            for (int i = 0; i < 12; i++)
            {
                profit[i] = income[i] - costs[i];
                if (profit[i] > 0)
                {
                    positiveProfit++;
                }

            }

            //Вывод данных

            Console.WriteLine("Месяц   Доход, тыс.руб.   Расход, тыс.руб.   Прибыль, тыс.руб.");

            for (int i = 0; i < 12; i++)
            {
                string incomFormated = income[i].ToString("### ###");
                string costsFormated = costs[i].ToString("### ###");
                string profitFormated = profit[i].ToString("### ###");

                Console.WriteLine($"{i+1,5} {incomFormated,17} {costsFormated,18} {profitFormated,18}");
            }



            profit.CopyTo(profitOld, 0);

           
            Array.Sort(profit);


            badMonth[0] = profit[0];
            int k = 1;

            int countSum = 1;

            while (countSum < badMonth.Length)
            {
                if (profit[k] != profit[k - 1])
                {
                    badMonth[countSum] = profit[k];
                    countSum++;
                }
                k++;
            }



            Console.Write($"\nХудшая прибыль в месяцах: ");

            for (int i = 0; i < badMonth.Length; i++)
            {
                for (int j = 0; j < profitOld.Length; j++)
                {
                    if (profitOld[j] == badMonth[i])
                    {
                        Console.Write($"{j + 1},");
                    }
                }
            }

            Console.WriteLine($"\nМесяцев с положительной прибылью: {positiveProfit}");

            Console.ReadKey();
            */


            /*
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            Console.WriteLine("Введите количество строк треугольника Паскля");
            int N = Convert.ToInt32(Console.ReadLine());

            //задаем массив массивов
            int[][] triangle = new int[N][];


            //инициируем массив массивов
            for (int i = 0; i < N; i++)
            {
                triangle[i] = new int[i + 1];
            }

            //задаем значение вершине
            triangle[0][0] = 1;

            //задаем значения крайним элементам треугольния
            for (int i = 0; i < N; i++)
            {
                triangle[i][0] = triangle[i][i] = 1;
            }

            //заполняем треугольник значениями

            for (int i = 1; i < triangle.Length - 1; i++)
            {


                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i-1][j] + triangle[i - 1][j - 1];
                }
                
            }

            //Устанавливаем положение курсора по центру консоли
            int top = 2;
            int center = Console.WindowWidth / 2;
            Console.SetCursorPosition(N, top);

            //Вывод массива
            for (int i = 0; i < triangle.Length-1; i++)
            {
                
                Console.SetCursorPosition(center, top);

                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write($"{triangle[i][j]} ");
                }
                           
                //изменяем координаты положения курсора
               center = center - 1;
                
                top++;
                Console.WriteLine();
            }
            Console.ReadKey();
            */


            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            /*
            Console.WriteLine($"Введите количество строк матрицы:");
            int countRow = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов матрицы:");
            int countColumn = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите число, на которое будем умножать матрицу:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[countRow,countColumn];

            Random random = new Random();

            Console.WriteLine($"Исходная матрица:");

            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countColumn; j++)
                {
                    matrix[i, j] = random.Next(10);
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nРезультат умножения исходной матрицы на {n}");
            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countColumn; j++)
                {
                    matrix[i, j] *= n;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            /*
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            Console.WriteLine($"Введите количество строк первой матрицы:");
            int countRow = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов первой  матрицы:");
            int countColumn = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество строк второй матрицы:");
            int countRowTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов второй  матрицы:");
            int countColumnTwo = int.Parse(Console.ReadLine());


            int[,] matrixOne = new int[countRow, countColumn];
            int[,] matrixTwo = new int[countRowTwo, countColumnTwo];

            
            Random random = new Random();

            Console.WriteLine($"Первая матрица:");

            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countColumn; j++)
                {
                    matrixOne[i, j] = random.Next(10);
                    Console.Write($"{matrixOne[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nВторая матрица:");
            for (int i = 0; i < countRowTwo; i++)
            {
                for (int j = 0; j < countColumnTwo; j++)
                {
                    matrixTwo[i, j] = random.Next(10);

                    Console.Write($"{matrixTwo[i, j]} ");
                }
                Console.WriteLine();
            }


             if (countColumn != countColumnTwo && countRow != countRowTwo)
            {
                Console.WriteLine($"\nНельзя складывать/вычитать матрицы разного размера!");
            }
            else
            {
                Console.WriteLine($"\nСумма двух матриц:");
                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumn; j++)
                    {
                       Console.Write($"{matrixOne[i, j] + matrixTwo[i,j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"\nРазность двух матриц:");
                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumn; j++)
                    {
                        Console.Write($"{matrixOne[i, j] - matrixTwo[i, j]} ");
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
            */

            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            //Ввод пользователем размеров матриц

            Console.WriteLine($"Введите количество строк первой матрицы:");
            int countRow = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов первой  матрицы:");
            int countColumn = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество строк второй матрицы:");
            int countRowTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов второй  матрицы:");
            int countColumnTwo = int.Parse(Console.ReadLine());


            int[,] matrixOne = new int[countRow, countColumn];
            int[,] matrixTwo = new int[countRowTwo, countColumnTwo];
            int[,] result = new int[countRow, countColumnTwo];

            

            //Заполнение матриц
            Random random = new Random();

            Console.WriteLine($"Первая матрица:");

            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countColumn; j++)
                {
                    matrixOne[i, j] = random.Next(10);
                    Console.Write($"{matrixOne[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nВторая матрица:");
            for (int i = 0; i < countRowTwo; i++)
            {
                for (int j = 0; j < countColumnTwo; j++)
                {
                    matrixTwo[i, j] = random.Next(10);

                    Console.Write($"{matrixTwo[i, j]} ");
                }
                Console.WriteLine();
            }

            //Проверка возможности умножения матриц одну на другую: количество столбцов первой матрицы должно быть равно количеству строк второй
            if (countColumn != countRowTwo)
            {
                Console.WriteLine($"Матрицу размером {countRow} x {countColumn} нельзя умножить на матрицу размером {countRowTwo} x {countColumnTwo}");
            }


            else
            {
                Console.WriteLine($"размер итоговой матрицы {countRow} x {countColumnTwo}");
                
                //вычисление значения элементов матрицы
                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumnTwo; j++)
                    {
                        for (int m = 0; m < countColumn; m++)
                            {
                               result[i, j] += matrixOne[i, m] * matrixTwo[m, j];
                            }              
                    }                    
                }

                //вывод на экран итоговой матрицы
                Console.WriteLine($"\nИтоговая матрица:");
                for (int i = 0; i < countRow; i++)
                {
                    for (int j = 0; j < countColumnTwo; j++)
                    {
                        Console.Write($"{result[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }



            Console.ReadKey();
        }
    }
}

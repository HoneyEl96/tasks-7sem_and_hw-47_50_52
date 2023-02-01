// Урок 7. Двумерные массивы

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = i+j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// void FillArrayWithRandom(int[,] matrix, int m, int n)
// {
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// matrix[i,j] = i+j;
// Console.Write(matrix[i,j] + "\t"); // \t - табуляция, для красивого вывода
// }
// Console.WriteLine();
// }
// }
// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix, m, n);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на 
// их квадраты. Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4

// void FillArrayWithRandom(int[,] matrix, int m, int n)
// {
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// matrix[i,j] = new Random().Next(-10, 11);
// Console.Write(matrix[i,j] + "\t");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }
// void NewMatrix(int[,] matrix, int m, int n)
// {
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// if(i%2 == 0 && j%2 == 0)
// {
// matrix[i,j] = matrix[i,j] * matrix[i,j];
// }
// Console.Write(matrix[i,j] + "\t");
// }
// Console.WriteLine();
// }
// }
// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix, m, n);
// NewMatrix(matrix, m, n);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// void FillArrayWithRandom(int[,] matrix, int m, int n)
// {
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// matrix[i,j] = new Random().Next(-10, 11);
// Console.Write(matrix[i,j] + "\t");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// void NewMatrix(int[,] array, int rows, int columns) // метод через столбцы и строки
// {
// int sum = 0;
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// if(i == j)
// {
// sum += array[i,j];
// }

//     }
// }
// Console.Write(sum);
// }
// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix, m, n);
// NewMatrix(matrix, m, n);

// Домашка:
// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void FillMatrixRandom(double[,] matrix, int rows, int columns) // rows - строки / columns - столбцы
// {
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// matrix[i,j] = Math.Round (Convert.ToDouble (new Random().NextDouble()) + (new Random().Next(-9,10)),1);
// Console.Write(matrix[i,j] + "\t"); // \t - табуляция, для красивого вывода
// }
// Console.WriteLine();
// }
// }
// Console.WriteLine("Введите число строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());
// double [,] matrix = new double[rows,columns];
// FillMatrixRandom(matrix, rows, columns);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7(ввод индексов) -> такого числа в массиве нет
// 1, 1 -> 9

// реализуем поиск, если кол-во итераций меньше или равно кол-ву введенных элементов, выводим; иначе выводим ошибку

// void FillMatrixRandom(int[,] matrix, int rows, int columns) // rows - строки / columns - столбцы
// {
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// matrix[i,j] = new Random().Next(0,10);
// Console.Write(matrix[i,j] + "\t"); // \t - табуляция, для красивого вывода
// }
// Console.WriteLine();
// }
// }

// void FindIndex(int[,] matrix, int rows, int columns) // поиск по индексу в матрице
// {
// Console.WriteLine("Введите строку, которую надо найти: ");
// int stroki = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец, который надо найти: ");
// int stolbci = Convert.ToInt32(Console.ReadLine());
// if (stroki < rows+1 && stolbci < columns+1)
//         {
//         for(int i = 0; i < rows; i++)
//         {
//         for(int j = 0; j < columns; j++)
//         {
//         }
//         }
//         Console.WriteLine("Вы искали число: " + matrix[stroki-1,stolbci-1]);
//         }
// else 
//     {
//     Console.WriteLine("вне диапазона"); 
//     }
// }
// Console.WriteLine("Введите число строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[rows,columns];
// FillMatrixRandom(matrix, rows, columns);

// FindIndex(matrix, rows, columns);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// вывод данных, должен быть, как минимум в формате double

void FillMatrixRandom(int[,] matrix, int rows, int columns) 
{
for(int i = 0; i < rows; i++)
{
for(int j = 0; j < columns; j++)
{
matrix[i,j] = new Random().Next(0,10);
Console.Write(matrix[i,j] + "\t"); 
}
Console.WriteLine();
}
}

void ArifmColumns(int[,] matrix, int rows, int columns) 
{
for(int j = 0; j < columns; j++) //тут пробегаем не по строке, а по столбцу
{
double sum = 0; // отвечает за сумму
double arifm = 0; // отвечает за сумму / на кол-во столбцов(строк)
for(int i = 0; i < rows; i++)
{
sum += matrix[i,j];
arifm = sum / rows;
}
Console.Write($"Среднее арифметическое в столбце {j+1}= ");
Console.Write(" " + Math.Round(arifm,1));
Console.WriteLine();
}
}
// исправил, можено в коммитах посмотреть
// засунул в первый цикл фор, чтобы отсчет каждый раз с нуля начинался

Console.WriteLine("Введите число строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,columns];
FillMatrixRandom(matrix, rows, columns);
ArifmColumns(matrix, rows, columns);
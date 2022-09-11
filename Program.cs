// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// Например:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double Number = Math.Round(array[i, j], 1);
            Console.Write(Number + " ");
        }
        Console.WriteLine();
    }
}


// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// void FillArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             array[a, b] = new Random().Next(1, 20);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             Console.Write($"{array[a, b]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int a = 3;
// int b = 4;
// int[,] array = new int[a, b];

// FillArray(array);
// PrintArray(array);

// Console.WriteLine("Enter number: ");
// int num = int.Parse(Console.ReadLine());
// string Position(int[,] array)
// {
//     string result = string.Empty;
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             if (num == array[m, n]) result += $"({m}, {n})";
//         }
//     }
//     if (result == string.Empty) result = "there is no such element in the array";
//     return result;
// }
// Console.WriteLine(Position(array));



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] randomArray = GetFillArray(3, 4);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine("Arithmetic mean of each column:");
FindAverage(randomArray);

int[,] GetFillArray(int c, int d)
{
    int[,] array = new int[c, d];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average = Math.Round(average / array.GetLength(0), 1, MidpointRounding.ToZero);
        Console.Write($"{average}; ");
        average = 0;
    }
}
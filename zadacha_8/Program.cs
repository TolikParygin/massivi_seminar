﻿// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
Console.Clear();



int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
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
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
System.Console.WriteLine();
PrintArray(matrix);

System.Console.WriteLine();
void OrderedArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = 0; count < array.GetLength(1); count++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                {
                    if (array[i, j] < array[i, j + 1])
                    {
                        int tempNumber = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = tempNumber;
                    }
                }
            }
        }
    }
}
OrderedArray(matrix);
PrintArray(matrix);
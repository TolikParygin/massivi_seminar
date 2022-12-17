// Задайте двумерный массив m*n, заполненный случайными числами.

Console.Clear();

int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
        return number;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange,rightRange);
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
           Console.Write($"{array[i,j]}  "); 
        }
        Console.WriteLine();
    }
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");
int[,] matrix = CreateRandomArray(m, n,10,100);
PrintArray(matrix);
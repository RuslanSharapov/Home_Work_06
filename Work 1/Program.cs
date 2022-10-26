// Показать двумерный массив размером m×n заполненный вещественными числами

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] array)
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


Console.Write("введите количество столбцов m: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.Write("введите количество строк n: ");
int n = int.Parse(Console.ReadLine()?? "0");

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
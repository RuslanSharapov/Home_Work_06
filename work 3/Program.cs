// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ChangeToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] *= array[i, j];
            }
            else
            {
                array[i, j] = array [i, j];
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($" {array[i, j]} ");
            } 
            else 
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("введите количество столбцов m: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.Write("введите количество строк n: ");
int n = int.Parse(Console.ReadLine()?? "0");

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeToSquare(array);
PrintArray(array);

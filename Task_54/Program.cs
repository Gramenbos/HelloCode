// 54. В матрице чисел найти сумму элементов главной диагонали

void FillTwoDimentionalArray(int[,] array, int minNumber, int maxNumber)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintTwoDimentionalArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int CalculateSumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, i];
    }
    return sum;
}

int[,] workArray = new int[3, 3];
if (workArray.GetLength(0) != workArray.GetLength(1))
{
    Console.WriteLine("Главной диагонали в массиве нет!");
    Environment.Exit(1);
}
FillTwoDimentionalArray(workArray, -9, 9);
PrintTwoDimentionalArray(workArray);
Console.WriteLine($"Сумма элементов главной диагонали равна {CalculateSumDiagonal(workArray)}");
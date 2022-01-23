// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
    Console.WriteLine();
}

int FindRowSum(int[,] array, int rowIndex)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[rowIndex, j];
    }
    return rowSum;
}

int FindMinRowSum(int[,] array)
{
    int minRowIndex = 0;
    int minSum = FindRowSum(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int currentSum = FindRowSum(array, i);
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int[,] workArray = new int[3, 2];
FillTwoDimentionalArray(workArray, -2, 2);
PrintTwoDimentionalArray(workArray);
int minRowIndex = FindMinRowSum(workArray);
Console.WriteLine($"Индекс строки с минимальной суммой элементов: {minRowIndex}");
Console.WriteLine($"Сумма её элементов равна {FindRowSum(workArray, minRowIndex)}");
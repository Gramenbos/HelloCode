// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

double[] CalculateAverageEveryColums(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumColumn += array[i, j];
        }
        resultArray[j] = sumColumn / array.GetLength(0);
    }
    return resultArray;
}

int[,] workArray = new int[5, 7];

FillTwoDimentionalArray(workArray, 0, 9);
PrintTwoDimentionalArray(workArray);
double[] resultArray = CalculateAverageEveryColums(workArray);
Console.Write("Average ");
foreach (double i in resultArray)
{
    Console.Write($"{i:N2}\t");
}
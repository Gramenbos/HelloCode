// 56. Написать программу, которая обменивает элементы первой строки и последней строки

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

void ChangeFirstAndLastRows(int[,] array)
{
    int lastElementIndex = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[lastElementIndex, j];
        array[lastElementIndex, j] = temp;
    }
}

int[,] workArray = new int[4, 4];

FillTwoDimentionalArray(workArray, 0, 9);
PrintTwoDimentionalArray(workArray);
ChangeFirstAndLastRows(workArray);
PrintTwoDimentionalArray(workArray);
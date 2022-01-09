//34. Написать программу замену элементов массива на противоположные

void FillAndPrintArray(int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
}

(int, int) SumPositiveAndNegative(int[] Array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >= 0)
            SumPositive += Array[i];
        else
            SumNegative += Array[i];
    }
    return (SumPositive, SumNegative);
}

void ReverseElements(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = -Array[i];
    }
}

void PrintArray(int[] Array)
{
    foreach (int element in Array)
        Console.Write($"{element}; ");
    Console.WriteLine();
}

int[] Array = new int[12];
FillAndPrintArray(Array, -9, 9);
(int SumPositive, int SumNegative) = SumPositiveAndNegative(Array);
Console.WriteLine();
Console.WriteLine($"{SumPositive}, {SumNegative}");
ReverseElements(Array);
PrintArray(Array);


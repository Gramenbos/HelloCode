//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillAndPrintArray(int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(int, int) MinMaxArray(int[] array)
{
    int minNumber = array[0];
    int maxNumber = array[0];
    foreach (int number in array)
    {
        if (number < minNumber) minNumber = number;
        if (number > maxNumber) maxNumber = number;
    }
    return (minNumber, maxNumber);
}

int[] Array = new int[12];
FillAndPrintArray(Array, 0, 9);
(int min, int max) = MinMaxArray(Array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max - min}");

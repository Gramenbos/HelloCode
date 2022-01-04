// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] Array) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-9, 10); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int[] Array = new int[12];   //Создал массив, состоящий из 12 элементов
FillArray(Array);   //Вызвал метод для заполнения массива

int SumPositive = 0;
int SumNegative = 0;    //Сумма отрицательных элементов массива, ъотя по условиям задачи числа положительные
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] >= 0)
    {
        SumPositive += Array[i];
    }
    else
    {
        SumNegative += Array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {SumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {SumNegative}");
// 47. Написать программу копирования массива

void FillArray(int[] Array) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-9, 10); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int[] CopyArray(int[] FirstArray)  //Метод для копирования массива (и вывод на печать)
{
    int[] SecondArray = new int[FirstArray.Length];     //Создал массив для копирования
    for (int i = 0; i < FirstArray.Length; i++)
    {
        SecondArray[i] = FirstArray[i];
        //Console.Write($"{SecondArray[i]} ");
    }
    return SecondArray;
}

int[] Array = new int[12];   //Создал массив, состоящий из 12 элементов
FillArray(Array);   //Вызвал метод для заполнения массива
int[] NewArray = CopyArray(Array);    //Вызвал метод для копирования массива

Console.WriteLine();
Console.WriteLine("Скопированный массив: ");
foreach (int Number in NewArray) Console.Write($"{Number} ");   //Вывод в консоль нового массива
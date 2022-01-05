// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] Array, int MinNumber, int MaxNumber) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(MinNumber, MaxNumber + 1); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int[] Array = new int[123];     //Создал массив, состоящий из 123 элементов
FillArray(Array, 0, 999);       //Вызвал метод для заполнения массива с указанием диапазона чисел
Console.WriteLine();

int Found = 0;    //Счетчик для искомых чисел

foreach (int Number in Array)
{
    if (10 <= Number && Number <= 99)    //Если число находится в диапазоне [10,99], то увеличиваем счетчик на 1
    {
        Found++;
    }
}

Console.WriteLine("В массиве {0} чисел из отрезка [10,99]", Found);
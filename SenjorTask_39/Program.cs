// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FillArray(int[] Array, int MinNumber, int MaxNumber) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(MinNumber, MaxNumber + 1); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int[] Array = new int[10];     //Создал массив, состоящий из 10 элементов
FillArray(Array, 0, 9);       //Вызвал метод для заполнения массива с указанием диапазона чисел
Console.WriteLine();

int Multiplication;    //Произведение пар чисел в массиве

for (int i = 0, j = Array.Length - 1; i < Array.Length / 2; i++, j--)    //i - индексы с начала массива, j - с конца. Проверяем до середины массива
{
    Multiplication = Array[i] * Array[j];
    Console.WriteLine("Произведение {0}-й пары чисел равно {1}", i + 1, Multiplication);
}
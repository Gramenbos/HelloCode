// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] Array, int MinNumber, int MaxNumber) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(MinNumber, MaxNumber + 1); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int[] Array = new int[10];     //Создал массив, состоящий из 10 элементов
FillArray(Array, 0, 99);       //Вызвал метод для заполнения массива с указанием диапазона чисел
Console.WriteLine();

int Sum = 0;    //Сумма элементов, стоящих на нечетной позиции

for (int i = 1; i < Array.Length; i += 2)
{
    Sum += Array[i];
}

Console.WriteLine("Сумма элементов массива, стоящих на нечетной позиции, равна {0}", Sum);
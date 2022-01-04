// 34. Написать программу для замены элементов массива на противоположные

void FillArray(int[] Array) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-9, 10); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

void ReverseArray(int[] Array)  //Метод для замены элементов массива на противоположные (и вывод на печать)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = -Array[i];
        Console.Write($"{Array[i]} ");
    }
}

int[] Array = new int[12];   //Создал массив, состоящий из 12 элементов
FillArray(Array);   //Вызвал метод для заполнения массива
Console.WriteLine();
ReverseArray(Array);    //Вызвал метод для замены элементов массива на противоположные
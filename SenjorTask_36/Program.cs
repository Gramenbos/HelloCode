// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] Array, int MinNumber, int MaxNumber) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(MinNumber, MaxNumber+1); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int[] Array = new int[20];   //Создал массив, состоящий из 20 элементов
FillArray(Array, 100, 999);   //Вызвал метод для заполнения массива с указаним диапазона чисел
Console.WriteLine();

int EvenNumbers = 0;    //Счетчик для четных элементов массива
int OddNumbers = 0;     //Счетчик для нечетных элементов массива
foreach (int Number in Array)
{
    if (Number % 2 == 0)    //Если остаток от деления от 2 равен 0, то увеличиваем счетик для четных чисел, иначе - для нечетных
    {
        EvenNumbers++;
    }
    else
    {
        OddNumbers++;
    }
}

Console.WriteLine("В массиве {0} четных чисел и {1} нечетных", EvenNumbers, OddNumbers);
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillDoubleArray(double[] Array) //Метод для заполнения массива случайными вещественными числами от 0 до 10
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().NextDouble() * 10; //Диапазон случайных чисел для заполнения массива 0-10
        Console.WriteLine($"{Array[i]} ");
    }
}

double[] Array = new double[10];    //Создал массив, состоящий из 10 элементов
FillDoubleArray(Array);             //Вызвал метод для заполнения массива
Console.WriteLine("-----------------------------");

double MinNumber = Array[0];           //Берем за минимальное и максимальное число первый элемент массива
double MaxNumber = Array[0];

foreach (double Number in Array)        //Находим максимальное и минимальное число в массиве
{
    if (Number < MinNumber) { MinNumber = Number; };
    if (Number > MaxNumber) { MaxNumber = Number; };
}
Console.WriteLine("Минимальное число равно {0}, максимальное число равно {1}", MinNumber, MaxNumber);
Console.WriteLine("Разница между ними равна {0} ", MaxNumber - MinNumber);
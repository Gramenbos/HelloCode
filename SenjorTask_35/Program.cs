// 35. Определить, присутствует ли в заданном массиве некоторое число 

void FillArray(int[] Array) //Метод для заполнения массива случайными числами (печать - для проверки)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-9, 10); //Диапазон случайных чисел для заполнения массива
        Console.Write($"{Array[i]} ");
    }
}

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int[] Array = new int[12];   //Создал массив, состоящий из 12 элементов
FillArray(Array);   //Вызвал метод для заполнения массива

Console.WriteLine();
int Number = EnterInt("Введите число для поиска в массиве: ");

bool PresentNumber = false; //Переменная для хранения "ложь", если числа нет, и "истина", если число есть

foreach (int index in Array)
{
    if (index == Number)
    {
        PresentNumber =  true; //Если есть хотя бы одно совпадение, то переменной присваивается значение true
    }
}

if (PresentNumber == true)
{
    Console.WriteLine("В массиве есть Ваше число!");
}
else
{
    Console.WriteLine("В массиве нет Вашего числа.");
}

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int EnterInt(string text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillTwoDimentionalArray(int[,] array, int minNumber, int maxNumber)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintTwoDimentionalArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

(int, int) FindElementInArray(int[,] array, int searchElement)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == searchElement) return (i, j);
        }
    }
    return (-1, -1);
}

Console.Clear();
Console.WriteLine("Вам предлагается определить размер массива.");
int arrayRows = EnterInt("Введите количество строк: ");
int arrayColumns = EnterInt("Введите количество столбцов: ");

int[,] workArray = new int[arrayRows, arrayColumns];
FillTwoDimentionalArray(workArray, -9, 9);
PrintTwoDimentionalArray(workArray);
int searchElement = EnterInt("Введите число для поиска: ");
(int i, int j) = FindElementInArray(workArray, searchElement);
if (i < 0) Console.WriteLine("Элемента в массиве нет!");
else Console.WriteLine("Адрес элемента в массиве: строка {0}, столбец {1}", i, j);
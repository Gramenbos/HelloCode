// 48. Показать двумерный массив размером m×n заполненный целыми числами

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Вам предлагается определить размер массива.");
int arrayRows = EnterInt("Введите количество строк: ");
int arrayColumns = EnterInt("Введите количество столбцов: ");

int[,] workArray = new int[arrayRows, arrayColumns];
FillTwoDimentionalArray(workArray, 0, 9);
PrintTwoDimentionalArray(workArray);
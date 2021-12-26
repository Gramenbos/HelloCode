// 21. Программа проверяет, является ли ЛЮБОЕ число палиндромом.

Console.WriteLine("Введите число: ");
string? StringNumber = Console.ReadLine();
if (StringNumber == null) StringNumber = String.Empty; //Если значение NULL, то присвоить пустую строку 
int Number = int.Parse(StringNumber);
int NumberLength = StringNumber.Length;
Console.WriteLine(Number);

/*
int[] CreateArrayFromConsole() // Метод для преобразования введенного числа в массив
{
    try
    {
        Console.WriteLine("Введите число: ");
        string? StringNumber = Console.ReadLine();
        if (StringNumber == null) StringNumber = String.Empty; //Если значение NULL, то присвоить пустую строку 
        int Number = int.Parse(StringNumber);
        int NumberLength = StringNumber.Length;
        int NumberFactor = 1;
        for (int i = 1; i < NumberLength; i++)
        {
            NumberFactor *= 10;             // Получаю 10 в степени X, где X - количество знаков в числе
        }

        // Инициализируем массив и наполняем массив цифрами из введенного числа
        int[] Array = new int[NumberLength];
        for (int i = 0, j = NumberFactor; i < NumberLength; i++, j = j / 10)
        {
            if (j == 0) break;
            Array[i] = Number / j;
            Number = Number % j;
        }
        return Array;
    }
    catch
    {
        Console.WriteLine("Input error.");
        int[] Array = { 0 };
        return Array;
    }

}

//Проверяем массив на палиндром
int[] Array = CreateArrayFromConsole();
int j = Array.Length - 1;
for (int i = 0; i < Array.Length / 2; i++, j--)
{
    if (Array[i] != Array[j])
    {
        Console.WriteLine("Ваше число - НЕ палиндром.");
        break;
    }
    else
    {
        if (i >= j - 2)
        {
            Console.WriteLine("Ваше число является палиндромом!");
        }
    }
}
/*
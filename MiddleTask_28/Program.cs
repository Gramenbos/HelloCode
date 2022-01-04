// 28. Подсчитать сумму цифр в числе

int[] CreateArray() // Метод для преобразования введенного числа в массив
{
    try
    {
        Console.WriteLine("Введите число: ");
        string? StringNumber = Console.ReadLine();
        if (StringNumber == null) StringNumber = String.Empty; //Если значение NULL, то присвоить пустую строку 
        int Number = int.Parse(StringNumber);
        if (Number < 0)
        {
            Console.WriteLine("Ваше число отрицательное!");
            Environment.Exit(1);
        }
        int NumberLength = StringNumber.Length;
        int NumberFactor = 1;
        for (int i = 1; i < NumberLength; i++)
        {
            NumberFactor *= 10;             // Получаю 10 в степени X, где X - количество знаков в числе
        }

        while (Number < NumberFactor)       // Проверяю, начинается ли число с 0
        {
            NumberFactor /= 10;             // Уменьшаю множитель в 10 раз
            NumberLength--;                 // Уменьшаю размер будущего массива на 1
        }

        // Инициализируем массив и наполняем массив цифрами из введенного числа
        int[] Array = new int[NumberLength];
        for (int i = 0, j = NumberFactor; i < NumberLength; i++, j /= 10)
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
        Environment.Exit(1);
        int[] Array = { 0 };
        return Array;
    }

}

//Считаем сумму чисел в массиве
int[] Array = CreateArray();
int Summ = 0;
for (int i = 0; i < Array.Length; i++)
{
    Summ += Array[i];
}

Console.WriteLine("Сумма чисел в массиве равна " + Summ);
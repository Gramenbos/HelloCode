// 45. Показать числа Фибоначчи

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

Console.Clear();
try
{
    int Number = EnterInt("Укажите, сколько показать чисел из последовательности Фибоначчи: ");
    int N1 = 0;
    int N2 = 1;         // Проверяем, сколько чисел хочет показать пользователь
    switch (Number)
    {
        case < 1:
            Console.WriteLine("Будем считать, я показал пустоту :)");
            break;
        case 1:
            Console.WriteLine(N1);
            break;
        case 2:
            Console.WriteLine($"{N1} \t {N2}");
            break;
        case < 45:
            Console.Write($"{N1} \t {N2} \t ");
            for (int i = 2; i < Number; i++)
            {
                int N3 = N2 + N1;
                Console.Write($"{N3} \t ");
                N1 = N2;
                N2 = N3;
                if (i % 10 == 0) Console.WriteLine();   //Чтобы показывать по 10 чисел в строке
            }
            break;
        default:
            Console.WriteLine("Вы слишком много хотите! Не могу посчитать :(");
            break;
    }
}
catch
{
    Console.WriteLine("Input error");
    Environment.Exit(1);
}
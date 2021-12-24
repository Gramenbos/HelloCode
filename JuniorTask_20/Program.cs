// 20. Задать номер четверти, показать диапазоны для возможных координат

int EnterInt(string Text)
{                                                       // Эта функция печатает в консоли нужный текст и возвращает 
    Console.WriteLine(Text);                            // введенное пользователем число
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int Quoter = EnterInt("Введите номер четверти плоскости: ");

if (Quoter == 1)    {Console.WriteLine("X > 0, Y > 0");}
    else if (Quoter == 2)   {Console.WriteLine("X < 0, Y > 0");}
    else if (Quoter == 3)   {Console.WriteLine("X < 0, Y < 0");}
    else if (Quoter == 4)   {Console.WriteLine("X > 0, Y < 0");}
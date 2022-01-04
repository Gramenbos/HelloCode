// 29. Написать программу вычисления произведения чисел от 1 до N

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{                                                    
    Console.Write(Text);                          
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int N = EnterInt("Введите N: ");
int Multyplication = 1;
for (int i = 1; i <= N; i++)
{
    Multyplication *= i;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно {Multyplication}");

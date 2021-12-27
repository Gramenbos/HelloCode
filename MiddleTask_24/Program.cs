// 24. Найти кубы чисел от 1 до N

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{                                                    
    Console.Write(Text);                          
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int N = EnterInt("Введите N: ");

Console.WriteLine("Число   |     Куб числа");

for (int i = 1; i <= N; i++)
{
    Console.WriteLine("{0,5}   |{1,10}", i, i * i * i);
}
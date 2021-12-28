// 25. Найти сумму чисел от 1 до А

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{                                                    
    Console.Write(Text);                          
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int A = EnterInt("Введите A: ");
int Sum = 0;
for (int i = 1; i <= A; i++)
{
    Sum += i;
}

Console.WriteLine("Сумма чисел от 1 до А равна " + Sum);
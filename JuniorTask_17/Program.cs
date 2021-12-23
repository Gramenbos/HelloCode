// 17. По двум заданным числам проверять, является ли одно квадратом другого

int EnterInt(string Text)
{                                                       // Эта функция печатает в консоли нужный текст и возвращает 
    Console.WriteLine(Text);                            // введенное пользователем число
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int Number1 = EnterInt("Введите первое число: ");
int Number2 = EnterInt("Введите второе число: ");

if (Number1 == Number2 * Number2 | Number2 == Number1 * Number1)
{
    Console.WriteLine("Одно число является квадратом другого!");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого.");
}
    
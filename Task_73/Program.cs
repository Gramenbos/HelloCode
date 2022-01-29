// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

string StringNumbers (int startFirst, int startSecond, int count)
{
    if (count == 0) return String.Empty;
    count--;
    return $"{startFirst} {StringNumbers(startSecond, startFirst + startSecond, count)}";
}

int startFirst = EnterInt("Введите первое число: ");
int startSecond = EnterInt("Введите второе число: ");
string sum = StringNumbers (startFirst, startSecond, 10);
Console.WriteLine(sum);
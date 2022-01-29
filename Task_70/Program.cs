// 70. Найти сумму цифр числа

int SumNumbers(int value)
{
    int temp = value % 10;
    if (value / 10 == 0) return temp;
    return temp + SumNumbers(value / 10);
}

Console.WriteLine(SumNumbers(-31035530));
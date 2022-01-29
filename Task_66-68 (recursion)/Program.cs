// 66. Показать натуральные числа от 1 до N, N задано
// 67. Показать натуральные числа от N до 1, N задано
// 68. Показать натуральные числа от M до N, N и M заданы

string PrintNumbersFrom1ToNumber(int n)
{
    if (n < 1) return string.Empty;
    return $"{PrintNumbersFrom1ToNumber(n - 1)} {n}";
}

string PrintNumbersFromNumberTo1(int n)
{
    if (n < 1) return string.Empty;
    return $"{n} {PrintNumbersFromNumberTo1(n - 1)}";
}

string PrintNumbersFromNumberToNumber(int m, int n)
{
    if (m > n) return string.Empty;
    return $"{m} {PrintNumbersFromNumberToNumber(m + 1, n)}";
}

int number = 10;
Console.Write(PrintNumbersFrom1ToNumber(number));
Console.WriteLine();
Console.Write(PrintNumbersFromNumberTo1(number));
Console.WriteLine();
int end = 50;
Console.Write(PrintNumbersFromNumberToNumber(number, end));
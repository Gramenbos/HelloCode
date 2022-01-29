// 72. Написать программу возведения числа А в целую стень B

double PowerNumber(double value, int power)
{
    if (power == 0) return 1;
    return value * PowerNumber(value, power - 1);
}

double result = PowerNumber(3, 3);
Console.WriteLine(result);
// Даны два числа. Показать большее и меньшее число

Console.Write("Первое число -> ");

int valueString1 = new Random().Next(0, 2);

Console.WriteLine(valueString1);

Console.Write("Второе число -> ");

int valueString2 = new Random().Next(0, 2);

Console.WriteLine(valueString2);

if (valueString1 == valueString2)
{
    Console.WriteLine("О чудо! Числа равны!");
}
else
{
    if (valueString1 > valueString2)
    {
        Console.WriteLine("Большее число: " + valueString1);

        Console.WriteLine("Меньшее число: " + valueString2);
    }
    else
    {
        Console.WriteLine("Большее число: " + valueString2);

        Console.WriteLine("Меньшее число: " + valueString1);
    }
}
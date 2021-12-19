
Console.Write("Введите первое число -> ");

string valueString1 = Console.ReadLine();

int valueInt1 = int.Parse(valueString1);

Console.Write("Введите второе число -> ");

string valueString2 = Console.ReadLine();

int valueInt2 = int.Parse(valueString2);

int square = valueInt2 * valueInt2;

if (valueInt1 == square)
{
    Console.Write("Первое число является квадратом второго!");
}
else
{
    Console.Write("Ты не угадал! Первое число не является квадратом второго!");
}


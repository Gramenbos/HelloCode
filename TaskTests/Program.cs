
Console.Write("Введите число -> ");

string valueString = Console.ReadLine();

int valueInt = int.Parse(valueString);

int square = valueInt * valueInt;

Console.WriteLine("Квадрат числа " + valueInt + " равен " + square);
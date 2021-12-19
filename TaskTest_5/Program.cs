// Найти максимальное из трех чисел

Console.Write("Введите первое число -> ");

int valueInt1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число -> ");

int valueInt2 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите третье число -> ");

int valueInt3 = int.Parse(Console.ReadLine() ?? "0");

int [] Numbers = {valueInt1, valueInt2, valueInt3};

int result = Numbers[0];

for (int i = 0; i < Numbers.Length; i++)
{
    if (result < Numbers[i])
    {
        result = Numbers[i];
    }
}

Console.Write("Максимальное число - " + result);
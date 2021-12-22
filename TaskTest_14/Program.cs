// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int number = 100;

Console.WriteLine("Исходное число: " + number);
Console.Write("Введите число для проверки кратности: ");

int MyNumber = Convert.ToInt32(Console.ReadLine());

if (number % MyNumber == 0)
{
    Console.WriteLine(number + " кратно Вашему числу!");
}
else
{
    Console.WriteLine("Числа не кратные, остаток от деления: " + number % MyNumber);
}

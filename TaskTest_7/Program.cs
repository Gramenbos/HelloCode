// Выяснить является ли число чётным

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное!");
}
else Console.WriteLine("Число нечетное.");

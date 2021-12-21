// Показать четные числа от 1 до N

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int number = 2;

while (number <= N)
{
    Console.Write(number + " ");
    number = number + 2;
}
// Показать числа от -N до N

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int number = -N;

while (number <= N)
{
    Console.WriteLine(number);
    number++;
}

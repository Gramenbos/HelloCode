// Показать вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Secondumber = ((number % 100) - ((number % 100) % 10)) / 10;

Console.Write("Вторая цифра: " + Secondumber);
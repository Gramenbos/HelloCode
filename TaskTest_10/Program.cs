// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Последняя цифра: " + (number % 100) % 10);

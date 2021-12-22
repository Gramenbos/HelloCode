// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);

Console.WriteLine("Случайное число: " + number);

int FirstNumber = number / 10;
int SecondNumber = number % 10;

if (FirstNumber >= SecondNumber) 
{
    Console.WriteLine("Наибольшая цифра числа: "+ FirstNumber);
}
else
{
    Console.WriteLine("Наибольшая цифра числа: "+ SecondNumber);
}


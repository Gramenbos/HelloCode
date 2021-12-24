// 21. Программа проверяет, является ли пятизначное число палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

// Инициализируем массив и наполняем массив цифрами из введенного числа
int[] Array = new int[5];
for (int i = 0, j = 10000; i < 5; i++, j = j / 10)
{
    Array[i] = Number / j;
    Number = Number - Array[i] * j;
}

//Проверяем массив на палиндром
if (Array[0] == Array[4] & Array[1] == Array[3])
{
    Console.WriteLine("Ваше число является палиндромом!");
}
else
{
    Console.WriteLine("Ваше число - НЕ палиндром.");
}
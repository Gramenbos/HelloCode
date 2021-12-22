// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите любое целое число: ");
string? Number = Console.ReadLine();                // Знак ? нужен, чтобы не было ошибки NULL
int Lenght = Number.Length;

if (Lenght > 2){
    Console.WriteLine("Третья цифра: " + Number[2]);        // Number[2] - это второй символ в строке Number
}
else{
    Console.WriteLine("Третьей цифры в Вашем числе нет!");
}
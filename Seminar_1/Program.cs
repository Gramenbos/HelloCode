
Console.WriteLine("Введите любое целое число: ");
string? StringNumber = Console.ReadLine();

try
{
    Convert.ToInt32(StringNumber);
    string Temp = StringNumber ?? "";
    int Length = Temp.Length;
    if (Length > 2)
    {
        Console.WriteLine("Третья цифра: " + Temp[Length-3]);
    }
    else
    {
        Console.WriteLine("Третьей цифры в числе нет!");
    }

}
catch
{
    Console.WriteLine("Неверный ввод!");
}
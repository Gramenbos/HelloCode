// 27. Определить количество цифр в числе

Console.WriteLine("Введите число: ");
string? StringNumber = Console.ReadLine();
if (StringNumber == null) StringNumber = String.Empty; //Если значение NULL, то присвоить пустую строку 
try
{
    ulong Number = Convert.ToUInt64(StringNumber);
    int NumberLength = StringNumber.Length;
    Console.WriteLine($"В вашем числе {NumberLength} цифр.");
}
catch (System.Exception)
{
    Console.WriteLine("Input error");
     Environment.Exit(1);
}


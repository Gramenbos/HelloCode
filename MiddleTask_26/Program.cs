// 26. Возведите число А в натуральную степень B используя цикл

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{                                                    
    Console.Write(Text);                          
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int A = EnterInt("Введите A: ");
int B = EnterInt("В какую степень возвести число А? ");

int Degree = 1;
for (int i = 1; i <= B; i++)
{
    Degree *= A;
}

Console.WriteLine($"Число {A} в {B} степени равно {Degree}");

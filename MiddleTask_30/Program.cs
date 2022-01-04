// 30. Показать кубы чисел, заканчивающихся на четную цифру - уточнение: кубы четных чисел от 1 до N

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{                                                    
    Console.Write(Text);                          
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int N = EnterInt("Введите N: ");

Console.WriteLine("Число   |     Куб числа");

for (int i = 2; i <= N; i = i + 2)  //Здесь вместо проверки каждого числа на четность просто увеличиваем число на 2
{
    Console.WriteLine("{0,5}   |{1,10}", i, i * i * i);
}
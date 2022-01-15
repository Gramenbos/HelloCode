// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// Если k1 = k2, то прямые параллельны!!! Если k различны, то прямые будут пересекаться
// Если b1 = b2, то прямые пересекаются в точке (0;b)
// Алгоритм решения такой: в одно из уравнений вставляем вместо "y" вставляем второе уравнение, и находим "x"
// Потом с помощью любого из уравнений находим "y"

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

Console.Clear();
Console.WriteLine("Вам предлагается ввести значение переменных для уравнений: ");
Console.WriteLine("y = k1 * x + b1,  y = k2 * x + b2");

double k1 = EnterInt("Введите k1: ");
double k2 = EnterInt("Введите k2: ");
double b1 = EnterInt("Введите b1: ");
double b2 = EnterInt("Введите b2: ");

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Координаты точки пересечения прямых: x = {0}, y = {1}", x, y);
}
else
{
    if (b1 == b2) Console.WriteLine("Прямые совпадают!");
    else Console.WriteLine("Прямые паралельны!");
}
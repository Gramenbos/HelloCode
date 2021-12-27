// 22. Найти расстояние между точками в пространстве 2D/3D

int EnterIntFromConsole(string Text)
{                                                       // Эта функция печатает в консоли нужный текст и возвращает 
    Console.Write(Text);                            // введенное пользователем число
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

Console.WriteLine("Введите координаты первой точки: ");
int X1 = EnterIntFromConsole("X = ");
int Y1 = EnterIntFromConsole("Y = ");
int Z1 = EnterIntFromConsole("Z = ");

Console.WriteLine("Введите координаты второй точки: ");
int X2 = EnterIntFromConsole("X = ");
int Y2 = EnterIntFromConsole("Y = ");
int Z2 = EnterIntFromConsole("Z = ");

double Distace = Math.Sqrt((X1-X2)*(X1-X2) + (Y1-Y2)*(Y1-Y2) + (Z1-Z2)*(Z1-Z2));

Console.WriteLine("Расстояние между точками " + Distace);
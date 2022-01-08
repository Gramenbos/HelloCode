// 46. Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.Write("Введите координаты вершин фигуры в формате (x, y) (x1,y1) ...: ");
string? Numbers = Console.ReadLine();       //Получаем одну строку
if (Numbers == null) { Numbers = "0"; }    //Если строка NULL, то присвоить "0"

Console.Write("Введите коэффициент масштабирования: ");
double Koefficient = Convert.ToDouble(Console.ReadLine());       //Получаем коэффициент в переменную

char[] Separators = new char[] { ',', ' ', '(', ')' };    //Обозначаем разделители (запятые, пробелы, скобки)

string[] SplitNumbers = Numbers.Split(Separators, StringSplitOptions.RemoveEmptyEntries);    //Разбиваем строку на подстроки и включаем их в массив. Игнорируем пустые строки
double[] WorkNumbers = new double[SplitNumbers.Length];     //Объявляем массив с числами

Console.Write("Координаты фигуры после масштабирования: ");
for (int i = 0; i < WorkNumbers.Length; i++)    //Переводим массив со строками в массив с числами и умножаем на коэффициент
{
    WorkNumbers[i] = Convert.ToDouble(SplitNumbers[i]);
    //Console.Write(WorkNumbers[i]);
    WorkNumbers[i] = WorkNumbers[i] * Koefficient;
    //Console.WriteLine(WorkNumbers[i]);
    if (i % 2 == 0)  //Для четных элементов массива делаем следующее:
    {
        Console.Write($"({WorkNumbers[i]}, ");
    }
    else            //Для нечетных элементов следующее:
    {
        Console.Write($"{WorkNumbers[i]}) ");
    }
}

//Console.WriteLine("Коэффициент: " + Koefficient);
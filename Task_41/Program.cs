// 41. Выяснить являются ли три числа сторонами треугольника 
// Каждая сторона должна быть меньше суммы двух других сторон

Console.Write("Введите стороны треугольника через запятую: ");
string? Numbers = Console.ReadLine();   //Получаем одну строку
if (Numbers == null) { Numbers = "0"; };    //Если строка NULL, то присвоить "0"

char[] Separators = new char[] { ',', ' ' };    //Обозначаем разделители

string[] SplitNumbers = Numbers.Split(Separators, StringSplitOptions.RemoveEmptyEntries);    //Разбиваем строку на подстроки и включаем их в массив. Игнорируем пустые строки
double[] WorkNumbers = new double[SplitNumbers.Length];     //Объявляем массив с числами

for (int i = 0; i < WorkNumbers.Length; i++)    //Переводим массив со строками в массив с числами
{
    WorkNumbers[i] = Convert.ToDouble(SplitNumbers[i]);
}

if ((WorkNumbers[0] + WorkNumbers[1]) > WorkNumbers[2] &&
    (WorkNumbers[0] + WorkNumbers[2]) > WorkNumbers[1] &&
    (WorkNumbers[1] + WorkNumbers[2]) > WorkNumbers[0])
{
    Console.WriteLine("Ваши числа могут быть длинами сторон треугольника.");
}
else
{
    Console.WriteLine("Ваши числа НЕ могут быть длинами сторон треугольника.");
}
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// сможете сделать через запятую, точку с запятой или ещё как, разбить строку можно методом Split

Console.Write("Введите числа через запятую: ");
string? Numbers = Console.ReadLine();       //Получаем одну строку
if (Numbers == null) { Numbers = "0"; }    //Если строка NULL, то присвоить "0"

char[] Separators = new char[] { ',', ' ' };    //Обозначаем разделители (запятые и пробелы)

string[] SplitNumbers = Numbers.Split(Separators, StringSplitOptions.RemoveEmptyEntries);    //Разбиваем строку на подстроки и включаем их в массив. Игнорируем пустые строки
int[] WorkNumbers = new int[SplitNumbers.Length];     //Объявляем массив с числами

int Count = 0;  //Объявили переменную - счетчик 

for (int i = 0; i < WorkNumbers.Length; i++)    //Переводим массив со строками в массив с числами и проверяем условие
{
    WorkNumbers[i] = Convert.ToInt32(SplitNumbers[i]);
    if (WorkNumbers[i] > 0) { Count++; }
    //Console.WriteLine(WorkNumbers[i]);
}

Console.WriteLine("Вы ввели {0} чисел больше 0.", Count);
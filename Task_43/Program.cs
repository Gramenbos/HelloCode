// 43. Написать программу преобразования десятичного числа в двоичное

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает введенное пользователем число
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int Number = EnterInt("Введите число для перевода в двоичную систему счисления: ");
int[] Array = new int[100];    //Объявили массив для наполнения его остатками от деления на 2
int Count = 0;                  //Счетчик количества цифр в двоичном числе (он же - длина массива)

for (int i = 0; Number > 0; i++)    //Выполняем цикл, пока наше число не станет 0
{
    Array[i] = Number % 2;          //Наполняем массив остатками от деления на 2
    Number /= 2;                    //Уменьшаем число в два раза
    Count = i + 1;                  //Увеличиваем счетчик количества цифр на 1
    //Console.Write($"{Number}  ");
    //Console.WriteLine(Array[i]);
}
//Console.WriteLine(Count);

int[] NewArray = new int[Count];    //Объявили массив для формирования готового числа. Наполняем его прошлым массивом "наоборот"
Console.Write("Ваше число в двоичной системе счисления: ");
for (int i = 0, j = Count - 1; i < Count; i++, j--)
{
    NewArray[i] = Array[j];
    Console.Write(NewArray[i]);
}
if (Count == 0) { Console.Write("0"); } //На тот случай, если введенное число 0
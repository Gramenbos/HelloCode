// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int EnterInt(string Text)
{                                                       // Эта функция печатает в консоли нужный текст и возвращает 
    Console.WriteLine(Text);                            // введенное пользователем число
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int X = EnterInt("Введите X: ");
int Y = EnterInt("Введите Y: ");

if (X > 0){
    if (Y > 0){
        Console.WriteLine("Точка находится в I четверти.");
    }
    else{
        Console.WriteLine("Точка находится в IV четверти.");
    }
}
else{
    if (Y > 0){
        Console.WriteLine("Точка находится во II четверти.");
    }
    else{
        Console.WriteLine("Точка находится в III четверти.");
    }
}
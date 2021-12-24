// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool TrueFalse(bool X, bool Y)
{
    Console.Write("Если X = {0}, Y = {1}, то: ", X, Y);
    bool First = !(X | Y);
    bool Second = !X & !Y;
    if (First == Second)    {
        Console.WriteLine("¬(X или Y) = {0}, ¬X и ¬Y = {1}", First, Second);
        Console.WriteLine("Утверждение ¬(X или Y) = ¬X и ¬Y истинно!");
        return true;
    }
    else    {
        Console.WriteLine("Ошибка!");
        return false;
    }
}

TrueFalse(true, true);
TrueFalse(true, false);
TrueFalse(false, true);
TrueFalse(false, false);
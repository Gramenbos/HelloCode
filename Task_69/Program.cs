// 69. Найти сумму элементов от M до N, N и M заданы

int SumElements(int start, int finish)
{
    if (start > finish) return 0;
    return start + SumElements(start + 1, finish);
}

Console.WriteLine($"Сумма элементов равна {SumElements(5, 10)}");
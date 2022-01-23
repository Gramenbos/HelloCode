// 60. Составить частотный словарь элементов двумерного массива
// Например: "Число 1 встречается 38 раз.  Частота 11.38%" и т.д.
// Добавил комментарии для тех, кто обучается, как и я.

void FillTwoDimentionalArray(int[,] array, int minNumber, int maxNumber)    // Метод для заполнения двумерного массива (min, max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintTwoDimentionalArray(int[,] array) // Метод для печати двумерного массива
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool FindEqualElement(int[] array, int findElement, int countElements) // Метод для проверки наличия элемента в одномерном массиве
{
    for (int i = 0; i < countElements; i++)
    {
        if (array[i] == findElement) return true;
    }
    return false;
}

int[] FindDifferentElement(int[] array) // Метод для заполнения массива неповторяющимися элементами
{
    int[] workArray = new int[array.Length];
    int countElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (!FindEqualElement(workArray, array[i], countElements))
        {
            workArray[countElements] = array[i];
            countElements++;
        }
    }
    return CopyArray(workArray, countElements);
}

int[] CopyArray(int[] array, int countElements) // Метод для копирования одномерного массива с указанием его длины
{
    int[] resultArray = new int[countElements];
    for (int i = 0; i < countElements; i++)
    {
        resultArray[i] = array[i];
    }
    return resultArray;
}

int[] CreateOnedementionArray(int[,] array) // Метод для превращения двумерного массива в одномерный
{
    int[] resultArray = new int[array.GetLength(0) * array.GetLength(1)];
    int i = 0;
    foreach (int element in array)
    {
        resultArray[i] = element;
        i++;
    }
    return resultArray;
}

void PrintOneDementionArray(int[] array)    // Метод для печати одномерного массива
{
    foreach (int element in array)
    {
        Console.Write($"{element}\t");
    }
    Console.WriteLine();
}

int CountUniqueElements(int[] array, int element)   // Метод для подсчета уникальных элементов в массиве
{
    int countElement = 0;
    foreach (int currentElement in array)
    {
        if (currentElement == element) countElement++;
    }
    return countElement;
}

int[,] FindFrequencyElements(int[] foundArray, int[] uniqueElementsArray)   // Метод для создания массива частоты элементов (1 столбец - уникальные элементы, 2 столбец - сколько раз встречается)
{
    int[,] resultArray = new int[uniqueElementsArray.Length, 2];
    for (int i = 0; i < uniqueElementsArray.Length; i++)
    {
        resultArray[i, 0] = uniqueElementsArray[i];
        resultArray[i, 1] = CountUniqueElements(foundArray, uniqueElementsArray[i]);
    }
    return resultArray;
}

void SortArray(int[,] array)    // Метод для сортировки двумерного массива по убыванию (по значениям во втором столбце)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0) - 1 - i; k++)
        {
            if (array[k, 1] < array[k + 1, 1])
            {
                int temp = array[k, 1];
                array[k, 1] = array[k + 1, 1];
                array[k + 1, 1] = temp;
                int temp2 = array[k, 0];
                array[k, 0] = array[k + 1, 0];
                array[k + 1, 0] = temp2;
            }
        }
    }
}

void PrintResult(int[,] array, double countElements)    // Метод для печати частотного словаря
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double frequencyElement = array[i, 1] * 100 / countElements;
        Console.WriteLine($"Число {array[i, 0]} встречается {array[i, 1]} раз. Частота {frequencyElement:N2}%");
    }
}

int[,] workArray = new int[4, 6];
FillTwoDimentionalArray(workArray, 0, 9);
PrintTwoDimentionalArray(workArray);

int[] foundArray = CreateOnedementionArray(workArray);
PrintOneDementionArray(foundArray);
int[] uniqueElementsArray = FindDifferentElement(foundArray);
PrintOneDementionArray(uniqueElementsArray);
int[,] resultArray = FindFrequencyElements(foundArray, uniqueElementsArray);
SortArray(resultArray);
PrintResult(resultArray, foundArray.Length);
// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели -> ");

string valueString = Console.ReadLine();

int valueInt = int.Parse(valueString);

if (0 < valueInt && valueInt < 8)
{
    if (valueInt == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else
    {
        if (valueInt == 2)
        {
            Console.WriteLine("Вторник");
        }
        else
        {
            if (valueInt == 3)
            {
                Console.WriteLine("Среда");
            } 
            else
            {
                if (valueInt == 4)
                {
                    Console.WriteLine("Четверг");
                } 
                else
                {
                    if (valueInt == 5)
                    {
                        Console.WriteLine("Пятница");
                    } 
                    else
                    {
                        if (valueInt == 6)
                        {
                            Console.WriteLine("Суббота");
                        } 
                        else
                        {
                            Console.WriteLine("Воскресенье");
                        }
                    }
                }
            }
        }
    }
    
}
else
{
    Console.WriteLine("Нет такого дня недели! В неделе всего 7 дней :)");
}
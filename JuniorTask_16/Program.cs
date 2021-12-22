// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите число, обозначающее день недели (1-7): ");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day == 6 | Day == 7){
    Console.WriteLine("Этот день ВЫХОДНОЙ!");
}
else{
    Console.WriteLine("Этот день не выходной :-(");
}
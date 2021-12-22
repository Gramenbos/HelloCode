// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число для проверки его кратности 7 и 23: ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 7 == 0 & Number % 23 == 0){
    Console.WriteLine("Число кратно 7 и 23.");
}
else{
    Console.WriteLine("Число не кратно 7 и 23.");
}
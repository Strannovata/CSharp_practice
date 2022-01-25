// 15. Дано число. Проверить кратно ли оно 7 и 23

int N = new Random().Next(0, 1000000);
if (N % 7 == 0) System.Console.WriteLine($"{N} кратно 7");
else System.Console.WriteLine($"{N} не кратно 7");
if (N % 23 == 0) System.Console.WriteLine($"{N} кратно 23");
else System.Console.WriteLine($"{N} не кратно 23");
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
int ReturnOst (int a, int b)
{
return b % a;
}
Console.WriteLine($"Задайте число:");
int zad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число, которое вы введете следующим, будем делить на {zad}:");
int num = Convert.ToInt32(Console.ReadLine());
int C = ReturnOst(zad, num);
if(C == 0) Console.WriteLine($"Число {num} кратно заданному ({zad})");
else Console.WriteLine($"Не кратно заданному. Остаток {C}");
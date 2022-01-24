// 8. Показать четные числа от 1 до N
int N = new Random().Next(1, 101);
for (int b = 1; b <= N; b++)
{
    if (b % 2 == 0) Console.Write($"{b} ");
}

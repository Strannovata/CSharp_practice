// 7. Показать числа от -N до N
int N = new Random().Next(0, 101);

for (int a = -N; a <= N; a++)
{
    Console.Write($"{a} ");
}
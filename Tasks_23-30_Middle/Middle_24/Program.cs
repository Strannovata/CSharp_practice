//24. Найти кубы чисел от 1 до N

void toCube(int N)
{
    for (int n = 1; n <= N; n++)
    {
       int result = n * n * n;
       System.Console.WriteLine($"{n}^3 = {result}");
    }
}
toCube(10);
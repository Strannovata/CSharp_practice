// 45. Показать числа Фибоначчи

int Fibonacci(int n)
{
    if (n == 0 || n == 1) return n;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}


void PrintFib(int N)
{
    for (int i = 0; i < N; i++)
    {
        System.Console.Write($"{Fibonacci(i)} ");
    }
    System.Console.WriteLine();
}


PrintFib(20);
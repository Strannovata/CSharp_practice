// 29. Написать программу вычисления произведения чисел от 1 до N

int GetMultiple (int N)
{
    int res = 1;
    for (int n = 1; n <= N; n++)
    {
        res = res * n;
    }
    return res;
}
int Num = new Random().Next(2,11);
int Mult = GetMultiple(Num);
System.Console.WriteLine($"Произведение чисел от 1 до {Num} равно {Mult}");
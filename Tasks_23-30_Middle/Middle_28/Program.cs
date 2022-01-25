// 28. Подсчитать сумму цифр в числе

int GetSumDigit (int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + (N % 10);
        N = N / 10;
    }
    return sum;
}
int number = new Random().Next();
int Sum = GetSumDigit(number);
System.Console.WriteLine($"Сумма цифр в числе {number} равна {Sum}");
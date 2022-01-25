//25. Найти сумму чисел от 1 до А

int GetSum(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum = sum + i;
    }
    return sum;
}
System.Console.WriteLine(GetSum(4));
// 27. Определить количество цифр в числе

int CountNumbers(int N)
{
    int count = 0;
    while (N > 0)
    {
        N = N / 10;
        count = count + 1;
    }
    return count;
}
int num = new Random().Next();
int count = CountNumbers(num);
System.Console.WriteLine($"В числе {num} == {count} символов");
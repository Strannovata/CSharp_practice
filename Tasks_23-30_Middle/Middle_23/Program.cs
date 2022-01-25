//23. Показать таблицу квадратов чисел от 1 до N 
void toSqare(int N)
{
    for (int n = 0; n <= N; n++)
    {
        int res = n * n;
        System.Console.WriteLine($"{n}^ = {res}");
    }
}
toSqare(100);
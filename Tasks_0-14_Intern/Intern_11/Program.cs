// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int GetMaxNumber(int num)
{
    int A = num / 10;
    int B = num % 10;
    if (A > B) return A;
    else return B;
}
int G = new Random().Next(10, 100);
int result = GetMaxNumber(G);
Console.WriteLine($"В числе {G} наибольшая цифра - {result}");

//11.1 Или через конвертацию
char GetMaxNumber(int num)
{
    string ab = Convert.ToString(num);
    char a = ab[0];
    char b = ab[1];
    if (a > b) return a;
    else return b;
}
int G = new Random().Next(10, 100);
char result = GetMaxNumber(G);
Console.WriteLine($"В числе {G} наибольшая цифра - {result}");


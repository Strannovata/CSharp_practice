// 26. Возведите число А в натуральную степень B используя цикл

int ToPower (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
System.Console.WriteLine(ToPower(3,8));
if (8==ToPower(2,3)) Console.WriteLine("Работает корректно");
else Console.WriteLine("Ошибочка");

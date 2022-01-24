//2. Даны два числа. Показать большее и меньшее число

int a = 6;
int b = 67;
int min = 0;
int max = 0;

if (a < b)
{
    min = a;
    max = b;
}
else
{
    min = b;
    max = a;
}
Console.WriteLine($"min = {min}, max = {max}");
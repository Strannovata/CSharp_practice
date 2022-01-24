//4. Найти максимальное из трех чисел
int a = 98;
int b = 103;
int c = 90;
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");
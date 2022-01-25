// // 17. По двум заданным числам проверять, является ли одно квадратом другого

void IsSquare(int a, int b)
{
    if (a * a == b) System.Console.WriteLine($"Число {b} - квадрат числа {a}");
    if (b * b == a) System.Console.WriteLine($"Число {a} - квадрат числа {b}");
    else System.Console.WriteLine($"Ни одно из чисел не является квадратом другого");
}
int n1 = new Random().Next(0, 100);
int n2 = new Random().Next(0, 100);
System.Console.WriteLine($"{n1}|||||{n2}");
IsSquare(n1, n2);
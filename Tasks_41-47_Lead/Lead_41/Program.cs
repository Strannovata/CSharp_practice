// 41. Выяснить являются ли три числа сторонами треугольника

bool IsTriangle(float a, float b, float c)
{
    if (((a + b) > c) && ((a + c) > b) && ((b + c) > a)) return true;
    else return false;
}

float A = new Random().Next(0, 10);
float B = new Random().Next(0, 10);
float C = new Random().Next(0, 10);

System.Console.WriteLine($"{A}, {B}, {C}");
// System.Console.WriteLine(IsTriangle(A, B, C));
if (IsTriangle(A, B, C) == true) System.Console.WriteLine("Числа являются сторонами треугольника");
else System.Console.WriteLine("Числа не являются сторонами треугольника");
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 k2 заданы

void FindIntersection(int k1, int b1, int k2, int b2)
{
    float x = (k2 * b2 - k1 * b1) / (b1 - b2);
    float y = k2 * x + b2;
    System.Console.WriteLine($"({x}, {y})");
}


FindIntersection(1, 3, 2, 4);

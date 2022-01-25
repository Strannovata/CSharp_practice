// 22. Найти расстояние между точками в пространстве 2D

double GetLengthBetween(double x1, double y1, double x2, double y2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double L = Math.Sqrt(x * x + y * y);
    return L;
}
double X1 = new Random().Next(-10, 11);
double Y1 = new Random().Next(-10, 11);
double X2 = new Random().Next(-10, 11);
double Y2 = new Random().Next(-10, 11);
double L = GetLengthBetween(X1, Y1, X2, Y2);
System.Console.WriteLine($"Расстояние между точками A ({X1};{Y1}) и B ({X2};{Y2}) равно {L}");

// 22.1 Найти расстояние между точками в пространстве 3D

double GetLengthBetween(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x1 - x2;
    double y = y1 - y2;
    double z = z1 - z2;
    double L = Math.Sqrt(x * x + y * y + z * z);
    return L;
}
double X1 = new Random().Next(-10, 11);
double Y1 = new Random().Next(-10, 11);
double Z1 = new Random().Next(-10, 11);
double X2 = new Random().Next(-10, 11);
double Y2 = new Random().Next(-10, 11);
double Z2 = new Random().Next(-10, 11);
double L = GetLengthBetween(X1, Y1, Z1, X2, Y2, Z2);
System.Console.Write($"Расстояние между точками A ({X1};{Y1};{Z1}) и B ({X2};{Y2};{Z2}) равно ");
System.Console.WriteLine(string.Format("{0:F2}", L));

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int FindQuarter(int x, int y)
{
    int q = 0;
    if (x > 0 && y > 0) q = 1;
    if (x < 0 && y > 0) q = 2;
    if (x < 0 && y < 0) q = 3;
    if (x > 0 && y < 0) q = 4;
    return q;
}
int X = new Random().Next(-100, 100);
int Y = new Random().Next(-100, 100);
int Q = FindQuarter(X, Y);
System.Console.WriteLine($"Точка с координатами ({X};{Y}) принадлежит {Q} четверти плоскости");
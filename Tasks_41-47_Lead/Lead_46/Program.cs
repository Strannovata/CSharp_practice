// 46. Написать программу масштабирования фигуры (квадрат/прямоугольник от центра)

void Scale(double x0, double y0, double lenX, double lenY, double scale)
{
    double x1 = x0 - lenX / 2;
    double x2 = x0 + lenX / 2;
    double y1 = y0 - lenY / 2;
    double y2 = y0 + lenY / 2;
    System.Console.WriteLine($"Координаты начальных точек: A({x1}, {y1}), B({x1}, {y2}), C({x2}, {y2}), D({x2}, {y1})");
    
    double nx1 = x0 - scale * lenX / 2;
    double nx2 = x0 + scale * lenX / 2;
    double ny1 = y0 - scale * lenY / 2;
    double ny2 = y0 + scale * lenY / 2;
    System.Console.WriteLine($"Координаты новых точек при масштабировании в {scale} раза: A({nx1}, {ny1}), B({nx1}, {ny2}), C({nx2}, {ny2}), D({nx2}, {ny1})");
}

Scale(2, 3, 2, 4, 3);

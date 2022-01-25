// 20. Ввести номер четверти, показать диапазоны для возможных координат

void FindRange(int q)
{
    if (q == 1) System.Console.WriteLine("X = (0;N), Y = (0;N)");
    if (q == 2) System.Console.WriteLine("X = (-N;0), Y = (0;N)");
    if (q == 3) System.Console.WriteLine("X = (-N;0), Y = (-N;0)");
    if (q == 4) System.Console.WriteLine("X = (0;N), Y = (-N;0)");
}
System.Console.WriteLine("Выберите четверть плоскости: ");
int quarter = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Вы можете чертить в диапазоне ");
FindRange(quarter);
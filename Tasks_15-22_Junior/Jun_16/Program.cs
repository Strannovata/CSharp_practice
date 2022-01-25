// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём
bool IsWeekend(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}
int n = new Random().Next(1, 8);
System.Console.Write(n);
if (IsWeekend(n)) System.Console.WriteLine(" - выходной день");
else System.Console.WriteLine(" - будний день");
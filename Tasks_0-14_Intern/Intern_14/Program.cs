// 14. Найти третью цифру числа (с начала) или сообщить, что её нет
int num = new Random().Next(-100000000, 100000000);
Console.WriteLine(num);
if (Math.Abs(num) < 100) Console.WriteLine("Третьей цифры нет");
else
{
    string number = Convert.ToString(num);
    int i = 2;
    if (num < 0) i = 3;
    char c = number[i];
    Console.WriteLine(c);
}

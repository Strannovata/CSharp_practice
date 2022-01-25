// 21. Программа проверяет пятизначное число на палиндром.

bool IsPalindrom(int n)
{
    string number = Convert.ToString(n);
    int n1 = number[0];
    int n2 = number[1];
    int n4 = number[3];
    int n5 = number[4];
    if (n1 == n5 && n2 == n4) return true;
    else return false;
}

int N = new Random().Next(10000, 100000);
if (IsPalindrom(N)) System.Console.WriteLine($"Число {N} - палиндром");
else System.Console.WriteLine($"Число {N} - не палиндром");
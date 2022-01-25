// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool IsTruth(bool x, bool y)
{
    if ((!(x || y)) == ((!x) && (!y))) return true;
    else return false;
}
bool a = true;
bool b = true;
if (IsTruth(a, b)) System.Console.WriteLine("Истина");
else System.Console.WriteLine("Ложь");
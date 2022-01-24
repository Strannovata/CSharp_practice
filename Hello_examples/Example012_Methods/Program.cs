// 1 группа методов. Ничего не принимает, ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор: Strannovata");
}

Method1();

// 2 группа методов. Что-то принимает, ничего не возвращает

void Method2(string msg)
{
Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст21", 5);
Method21(count: 4, msg: "New text");

// 3 группа методов. Ничего не принимает, что-то возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// 4 группа методов. Что-то принимает, что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(7, "qwerty ");
Console.WriteLine(res);


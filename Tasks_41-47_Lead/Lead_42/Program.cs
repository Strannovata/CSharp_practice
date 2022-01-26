// 42. Определить сколько чисел больше 0 введено с клавиатуры

int CountPositive(int N)
{
    int[] array = new int[N];
    int i = 0;
    int number = 1;
    int count = 0;

    for (i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите число {number}>>> ");
        string S = System.Console.ReadLine();
        array[i] = Convert.ToInt32(S);
        number++;
    }

    for (i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int result = CountPositive(10);
System.Console.WriteLine($"Это ваши числа, а количество положительных>>> {result}");
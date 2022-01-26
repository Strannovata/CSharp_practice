// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] GetArray(int N, int minvalue, int maxvalue)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minvalue, maxvalue);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] newarray = GetArray(10, 0, 100);
PrintArray(newarray);

int SumElementOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}

int result = SumElementOddPosition(newarray);
System.Console.WriteLine(result);
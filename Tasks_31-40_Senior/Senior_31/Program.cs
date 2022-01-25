// 31. Задать массив из 8 элементов и вывести их на экран

int[] GetArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

int[] massive = GetArray(8);
PrintArray(massive);
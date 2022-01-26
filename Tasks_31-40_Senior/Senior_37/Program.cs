// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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

int[] newarray = GetArray(123, -1000, 1000);
PrintArray(newarray);

int CountElement(int[] array, int minvalue, int maxvalue)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= minvalue) && (array[i] <= maxvalue + 1)) count++;
    }
    return count;
}

int count = CountElement(newarray, 10, 99);
System.Console.WriteLine(count);
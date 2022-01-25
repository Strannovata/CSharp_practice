// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

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

int[] defarray = GetArray(10, 100, 1000);
PrintArray(defarray);

int GetCountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int GetCountOdd(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) count++;
    }
    return count;
}

int countEven = GetCountEven(defarray);
int countOdd = GetCountOdd(defarray);
System.Console.WriteLine($"Количество четных элементов: {countEven}");
System.Console.WriteLine($"Количество нечетных элементов: {countOdd}");
// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
//Найти сумму положительных/отрицательных элементов массива

int [] GetArray(int N, int minvalue, int maxvalue)
{
    int [] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minvalue, maxvalue);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] defarray = GetArray(12, -9, 9);
PrintArray(defarray);

int GetSumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum = sum + array[i];
    }
    return sum;
}

int GetSumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum = sum + array [i];
    }
    return sum;
}

int sumPos = GetSumPositive(defarray);
int sumNeg = GetSumNegative(defarray);
System.Console.WriteLine($"Сумма положительных элементов: {sumPos}");
System.Console.WriteLine($"Сумма отрицательных элементов: {sumNeg}");
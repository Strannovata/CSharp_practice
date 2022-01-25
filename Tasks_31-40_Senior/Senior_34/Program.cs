// 34. Написать программу замену элементов массива на противоположные

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

int[] ReplaceOppositeArray(int[] array)
{
    int[] arrayOpp = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayOpp[i] = array [i] * -1;
    }
    return arrayOpp;
}

int[] array1 = ReplaceOppositeArray(defarray);
PrintArray(array1);
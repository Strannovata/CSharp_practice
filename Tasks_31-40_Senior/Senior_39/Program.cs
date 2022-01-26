// 39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

int[] newarray = GetArray(10, 0, 10);
PrintArray(newarray);

int[] MultipleOfPairs(int[] array)
{
    int[] multArray = new int[array.Length / 2];
    int j = array.Length - 1;
    for (int i = 0; i < multArray.Length; i++)
    {
        multArray[i] = array[i] * array[j];
        j = j - 1;
    }
    return multArray;
}

int[] result = MultipleOfPairs(newarray);
PrintArray(result);
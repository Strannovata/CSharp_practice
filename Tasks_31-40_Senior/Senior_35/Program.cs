// 35. Определить, присутствует ли в заданном массиве, некоторое число

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

int[] defarray = GetArray(10, -10, 11);
PrintArray(defarray);

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

int N = 5;
bool result = FindNumber(defarray, N);
if (result == true) System.Console.WriteLine($"Число {N} присутствует в массиве");
else System.Console.WriteLine($"Число {N} отсутствует в массиве");
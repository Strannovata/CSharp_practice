// 43. Написать программу преобразования десятичного числа в двоичное

int CountElements(int N)
{
    int count = 0;
    while (N > 0)
    {
        N = N / 2;
        count += 1;
    }
    return count;
}

int[] ConversToBinary(int N, int L)
{
    int[] array = new int[L];
    while (N > 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = N % 2;
            N = N / 2;
        }
    }
    return array;
}

int number = 13;
int length = CountElements(number);
int[] defoltArray = ConversToBinary(number, length);

void PrintArray(int[] array)
{
    for (int i = array.Length - 1; i >=0; i--)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(defoltArray);

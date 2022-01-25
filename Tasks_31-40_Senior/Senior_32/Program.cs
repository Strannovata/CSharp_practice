// 32. Задать массив из 8 элементов, заполненный нулями и единицами, и вывести их на экран

int[] GetArrayBy01(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
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


int[] array01 = GetArrayBy01(8);
PrintArray(array01);



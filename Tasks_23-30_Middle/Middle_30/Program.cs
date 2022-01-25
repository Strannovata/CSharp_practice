// 30. Показать кубы чисел, заканчивающихся на четную цифру

int[] GetArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void Printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] numbers = GetArray(10);
Printarray(numbers);


int[] ToCube(int[] array)
{
    int[] array2 = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) array2[i] = array[i] * array[i] * array[i];
        else array2[i] = 0;
    }
    return array2;
}
int[] cubes = ToCube(numbers);
Printarray(cubes);
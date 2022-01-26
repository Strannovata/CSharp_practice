// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] GetArray(int N, int minvalue, int maxvalue)
{
    double[] array = new double[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minvalue, maxvalue);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double[] newarray = GetArray(10, -9, 10);
PrintArray(newarray);

double DifferenceMinMax(double[]array)
{
    double[] defoltarray = array;
    double MaxValue(double[] defoltarray)
    {
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }
    
    double MinValue(double[] defoltarray)
    {
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
        return min;
    }

    return (MaxValue(defoltarray)- MinValue(defoltarray));
}

double result = DifferenceMinMax(newarray);
System.Console.WriteLine(result);
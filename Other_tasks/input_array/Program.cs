// Введение массива с клавиатуры
int[] array = new int[10];
int i = 0;

for (i = 0; i < array.Length; i++)
{
    System.Console.WriteLine("Введите число>>> "); 
    string S = Console.ReadLine();
    array[i] = Convert.ToInt32(S);
}

for (i = 0; i < array.Length; ++i)
{
    Console.Write(array[i] + " ");
}

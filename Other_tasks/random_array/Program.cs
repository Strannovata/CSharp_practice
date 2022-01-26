// Заполнение массива случайными числами

int[] array = new int[10];
Random rnd = new Random();

for(int i= 0; i < 10; i++)
{
array[i] = rnd.Next(0,100); //диапазон от 1 до 99
}
for(int i = 0; i < 10; i++)
{
Console.Write(array[i] + " ");
}

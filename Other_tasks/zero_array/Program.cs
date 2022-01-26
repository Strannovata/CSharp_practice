// Обнуление массива
int[] massive = new int[10]; //создание и заполнение массива
int ind = 0;
for(ind=0; ind < 10; ++ind)
{
    Console.WriteLine(massive[ind]);
}

//1 способ
while(ind < 10)
{
    massive[ind] = 0;
    ++ind;
}

System.Console.WriteLine();

//2 способ
for(int i=0; i < 10; ++i)
{
massive[i] = 0;
}

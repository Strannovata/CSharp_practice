// Найти минимальное из трех чисел

int Min(int a, int b, int c)
{ 
int min = a;
if (b < min) min = b;
if (c < min) min = c; 

return(min);
}

int a = 17;
int b = 84;
int c = 35;

Console.WriteLine(Min(a,b,c));
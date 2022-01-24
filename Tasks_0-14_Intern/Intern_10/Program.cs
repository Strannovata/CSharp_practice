// 10. Показать вторую цифру трёхзначного числа
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int found = num / 10 % 10;
Console.WriteLine(found);
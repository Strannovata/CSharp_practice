// 9. Показать последнюю цифру трёхзначного числа
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int found = num % 10;
Console.WriteLine(found);

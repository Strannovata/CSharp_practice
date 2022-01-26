// dog
double distance0 = 10;
double FirstfriendSpeed = 5;
double SecondFriendSpeed = 6;
double DogSpeed = 10;
double distance = 1000;
double time = 0;
int friend = 2; //собака бежит от 1 друга ко 2
int count = 0;

while (distance > distance0)
{
if (friend == 2)
{
time = distance / (SecondFriendSpeed + DogSpeed);
friend = 1;
}
else
{
time = distance / (FirstfriendSpeed + DogSpeed);
friend = 2;
}
distance = distance - (FirstfriendSpeed + SecondFriendSpeed) * time;
count++;
Console.Write($"Собака пробежала {count} раз(а)  |  ");
Console.WriteLine($"Расстояние = {distance:F2}");
}
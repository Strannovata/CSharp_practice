// Задача 1 ====Работа с текстом
// Дан текст. В тексте нужно:
// все пробелы заменить черточками
// маленькие буквы "к" заменить большими "К"
// большие "С" заменить маленькими "с"
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
string result = String.Empty;
int length = text.Length;

for(int i=0; i<length; i++)
{
    if(text[i]==oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
}
return result;
}
string Newtext = Replace(text, ' ', '|');
Console.WriteLine(Newtext);

Console.WriteLine();
Newtext = Replace(text, 'к', 'К');
Console.WriteLine(Newtext);

Console.WriteLine();
Newtext = Replace(text, 'о', '0');
Console.WriteLine(Newtext);
*/

// Задача 2 ==== Сортировка массива
/*
int[] arr = {1,5,4,3,2,6,7,1,1};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectSort (int[] array)
{
    for (int i=0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array [i] = array [minPosition];
        array [minPosition] = temp;
    }
}

PrintArray(arr);
SelectSort(arr);
PrintArray(arr);
*/

// Задача 2 ==== Сортировка массива/ А если отсортировать его в порядке убывания?

int[] arr = {1,5,4,3,2,6,7,1,1};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectSort (int[] array)
{
    for (int i=0; i < array.Length -1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array [i] = array [maxPosition];
        array [maxPosition] = temp;
    }
}

PrintArray(arr);
SelectSort(arr);
PrintArray(arr);
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число 
//в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[7];
void FillArray(int[] collection)
{
    int i = 0;
    int length = collection.Length;
    while (i < length)
    {
        collection[i] = new Random().Next(-9, 10);
        i++;
    }
}

void PrintArray(int[] col)
{
    int index = 0;
    int count = col.Length;
    while (index < count)
    {
        Console.Write($"{col[index]}, ");
        index++;
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();

void findNum(int[] arr, int num)
{
    int i = 0;
    int find = 5;
    bool flag = false;
while (i < arr.Length)
{
    if (arr[i] == find) flag = true;
    i++;
}
if (flag == true) Console.WriteLine($"\nЧисло {find} присутствует в массиве");
else Console.WriteLine($"Числа {find} в массиве нет");
}
findNum(array, 5);

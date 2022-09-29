//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[4];
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

int i = 0;
for (i = 0; i < array.Length; i++)
{
    Console.Write($"{-array[i]}, ");
}
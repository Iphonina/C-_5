// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] array = new int[123];
void FillArray(int[] collection)
{
    int i = 0;
    int length = collection.Length;
    while (i < length)
    {
        collection[i] = new Random().Next(0, 150);
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

int i = 0;
int count = 0;
while (i < array.Length)
{
    if (array[i] > 9 && array[i] < 100) count = count + 1;
    i++;
}
Console.WriteLine($"\nКоличество элементов в отрезке [10, 99] равно {count}");
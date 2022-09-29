// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[9];
void FillArray(int[] collection)
{
    int i = 0;
    int length = collection.Length;
    while (i < length)
    {
        collection[i] = new Random().Next(0, 10);
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
int[] collection = new int[array.Length / 2];
while (i < array.Length / 2)
{
    collection[i] = array[i] * array[array.Length - 1 - i];
    Console.Write($"{collection[i]}, ");
    i++;
}
if (array.Length % 2 == 1) Console.Write($"{array[array.Length / 2]}");
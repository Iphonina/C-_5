// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// //Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
void FillArray(int[] collection)
{
    int i = 0;
    int length = collection.Length;
    while (i < length)
    {
        collection[i] = new Random().Next(-100, 101);
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

int i = 1;
int sum = 0;

while (i < array.Length)
{
    sum = sum + array[i];
    i = i + 2;
}

Console.WriteLine($"\nСумма элементов, стоящих на нечетных позициях, равна {sum}");

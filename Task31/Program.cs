// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] array = new int[12];
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

void Sum(int[] array)
{
int i = 0;
int sumPlus = 0;
int sumOtr = 0;
while (i < array.Length)
{
    if (array[i] > 0) sumPlus = sumPlus + array[i];
    else sumOtr = sumOtr + array[i];
    i++;
}
Console.WriteLine($"\nСумма положительных чисел в массиве равна {sumPlus}");
Console.WriteLine($"Сумма отрицательных чисел в массиве равна {sumOtr}");
}
Sum(array);


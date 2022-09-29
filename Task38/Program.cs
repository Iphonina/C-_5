// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементом массива.
//[3 7 22 2 78] -> 76

double[] array = new double[15];
void FillArray(double[] collection)
{
    int i = 0;
    int length = collection.Length;
    while (i < length)
    {
        collection[i] = new Random().Next(-9, 10);
        i++;
    }
}

void PrintArray(double[] col)
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

double MaxNum(double[] array)
{
    int i = 0;
    double max = array[0];
    while (i < array.Length)
    {
        if (array[i] > max) max = array[i];
        i++;
    }
    return max;
}

double maxNumber = MaxNum(array);

double MinNum(double[] array)
{
    int i = 0;
    double min = array[0];
    while (i < array.Length)
    {
        if (array[i] < min) min = array[i];
        i++;
    }
    return min;
}

double minNumber = MinNum(array);

Console.WriteLine($"\nмаксимальный элемент массива {maxNumber}");
Console.WriteLine($"минимальный элемент массива {minNumber}");
Console.WriteLine($"Разница между max и min значением массива составляет {maxNumber - minNumber}");
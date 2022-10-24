// Написать программу копирования массива

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] mirrorarray)
{
    int[] copy = new int[mirrorarray.Length];
    for (int i = 0; i < mirrorarray.Length; i++)
    {
        copy[i] = mirrorarray[i];
    }
    return copy;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int size = 10;
int min = 1;
int max = 100;

int[] mirror = GetArray(size, min, max);
Console.WriteLine("Исходный массив А:");
PrintArray(mirror);
Console.WriteLine();
Console.WriteLine("Копия массива А:");
int[] copy = CopyArray(mirror);
PrintArray(copy);

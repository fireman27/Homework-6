﻿// Показать числа фибоначчи
Console.Write("Введите колличество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Количество чисел Фибоначчи: {N}");

int[] GetFibonacci(int N)
{
    int prev1 = 1;
    int prev2 = 1;
    int[] fib = new int[N];
    fib[0] = 1;
    fib[1] = 1;
    for (int i = 2; i < N; i++)
    {
        fib[i] = prev1 + prev2;
        prev2 = prev1;
        prev1 = fib[i];
    }
    return fib;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(GetFibonacci(N));
Console.WriteLine();
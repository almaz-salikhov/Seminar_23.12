﻿void SelectionSortFromMax(int[] arr) // сортировка элементов временного одномерного массива
{
    for (int i = 0; i < arr.Length - 1; i++) // мы начинаем с i + 1 (не трогаем отсортированное), а поэтому длина массива уже не array.Length, а array.Length - 1
    {
        int maxPosition = i; // запоминаем позицию "рабочего элемента"
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition])
                maxPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}

void SelectionSortFromMin(int[] arr) // сортировка элементов временного одномерного массива
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition])
                minPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[] { 1, 6, 8, 3, 5, 2, 9, 6 };
PrintArray(array);

SelectionSortFromMax(array);
PrintArray(array);
SelectionSortFromMin(array);
PrintArray(array);

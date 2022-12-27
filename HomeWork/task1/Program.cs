// Задайте двумерный массив
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// 1) задать массив
// 2) пройтись по каждой строке и расставить по убыванию 

void FillArrayWithRandom(int[,] arr) // Fill array with random
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int[] arr) // сортировка элементов временного одномерного массива
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temporary;
    }
}

void SortElementsInRowByDescending(int[,] arr) // сортировка строки 2-мерного через создание временного 1-мерного
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] arrRow = new int[arr.GetLength(1)];

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arrRow.Length; k++)
            {
                arrRow[k] = arr[i, j++];
            }
            // Console.WriteLine(i + " строка: " + string.Join(", ", arrRow));
        }
        SelectionSort(arrRow);
        for (int j = 0, k = 0; j < arr.GetLength(1); j++, k++)
        {
            arr[i, j] = arrRow[k];
        }
    }
}

int[,] array = new int[4, 4];
FillArrayWithRandom(array);
ShowArray(array);
SortElementsInRowByDescending(array);
Console.WriteLine();

ShowArray(array);


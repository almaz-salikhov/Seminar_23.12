// Задайте прямоугольный двумерный массив. Напишите программу
// Программа ищет строку с наименьшей суммой элементов
// и выдаёт ее номер: 1 строка

void FillArrayWithRandom(int[,] arr)
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

int FindMinSumRow(int[] arr)
{
    int minNumber = arr.Min();
    int indexMin = Array.IndexOf(arr, minNumber);
    int numberOfMinSumRow = indexMin + 1;
    return numberOfMinSumRow;
}

int[] CreateArrayOfSum(int[,] arr)
{
    int[] arrayOfSum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        arrayOfSum[i] = sum;
    }
    Console.WriteLine(string.Join(", ", arrayOfSum));
    Console.WriteLine();
    return arrayOfSum;
}

int[,] array = new int[6, 4];
FillArrayWithRandom(array);
ShowArray(array);
Console.WriteLine();

int[] arrayOfSum = CreateArrayOfSum(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinSumRow(arrayOfSum)}");
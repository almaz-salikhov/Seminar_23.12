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
    int imin = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            imin = i;
        }
    }
    int numberOfMinSumRow = imin + 1;
    return numberOfMinSumRow;
}

int[,] array = new int[6, 4];
FillArrayWithRandom(array);
ShowArray(array);
Console.WriteLine();

int[] arrayOfSum = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    arrayOfSum[i] = sum;
    // Console.WriteLine($"Сумма элементов строки с индексом {i} = {sum}");
}
Console.WriteLine(string.Join(", ", arrayOfSum));
Console.WriteLine();


Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinSumRow(arrayOfSum)} ");

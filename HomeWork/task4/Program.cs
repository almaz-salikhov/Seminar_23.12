// Сформировать двумерный массив из неповторяющихся случайных двузначных чисел
// Вывести полученный массив 

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

bool IsNumberExistInArray(int[,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (value == arr[i, j])
            {
                return true;
            }
        }
    }
    return false;
}

void FillArrayWithRandom(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int elem = rnd.Next(10, 100);
            if (IsNumberExistInArray(arr, elem) == false)
            {
                arr[i, j] = elem;
            }
            else
            {
                j--;
            }
        }
    }
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, column];
if (row * column > 90)
{
    Console.Write("Размер массива выше допустимого (максимум 90 элементов)");
}
else
{
    FillArrayWithRandom(array);
    Console.WriteLine();
    ShowArray(array);
}

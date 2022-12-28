// Программа, которая ищет произведение матриц (квадратных, но с проверкой под любой)

void FillArrayWithRandom(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 5);
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

int[,] MatrixMultiplication(int[,] m1, int[,] m2)
{
    int[,] matrixMult = new int[m1.GetLength(0), m2.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++) // идем по строкам 1 матрицы
    {
        for (int j = 0; j < m2.GetLength(1); j++) // проходясь по столбцам 2 матрицы
        {
            for (int k = 0; k < m2.GetLength(0); k++)
            {
                matrixMult[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    return matrixMult;
}

int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];
FillArrayWithRandom(matrix1);
FillArrayWithRandom(matrix2);
Console.WriteLine("Первая матрица: ");
ShowArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
ShowArray(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    Console.WriteLine("Произведение матриц: ");
    ShowArray(MatrixMultiplication(matrix1, matrix2));;
}


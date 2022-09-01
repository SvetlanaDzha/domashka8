// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = Input("Введите количество строк первой матрицы m: ");
int n = Input("Введите количество столбцов первой матрицы n: ");
int x = Input("Введите количество строк второй матрицы x: ");
int y = Input("Введите количество столбцов второй матрицы y: ");

int[,] oneArray = new int[m, n];
FillArray(oneArray);
Console.WriteLine("Первая матрица");
PrintArray(oneArray);

int[,] twoArray = new int[x, y];
FillArray(twoArray);
Console.WriteLine("Вторая матрица");
PrintArray(twoArray);

int[,] matrixSumm = Сomposition(oneArray, twoArray);
PrintArray(matrixSumm);

int[,] Сomposition(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Нет возможности найти произведение матриц");
        return matrix1;
    }
    int[,] matrixSumm = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixSumm[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixSumm;
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
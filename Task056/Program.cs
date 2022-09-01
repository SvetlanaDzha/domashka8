// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int tempSum = 0;
for (var i = 0; i < array.GetLength(1); i++)
{
    tempSum += array[0, i];
}

int position = 0;
for (var i = 0; i < array.GetLength(0); i++)
{
    int lineSum = 0;
    for (var j = 0; j < array.GetLength(1); j++)
    {
        lineSum += array[i, j];
    }
     Console.WriteLine($"Строка {i} = {lineSum}");
    if(tempSum > lineSum)
    {
        tempSum = lineSum;
        position = i;
    }
}
Console.WriteLine($"Строка {position} с наименьшей суммой элементов = {tempSum} ");

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
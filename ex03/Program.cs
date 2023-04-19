//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}
int[,] CreateArray(int masRows, int masColumns)
{
    int[,] array = new int[masRows, masColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}
void Print2DArrayMas(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] MultiMas(int[,] arrayFirst, int[,] arraySecod)
{
    int[,] multi = new int[arrayFirst.GetLength(0), arraySecod.GetLength(1)];
    for (int i = 0; i < multi.GetLength(0)-1; i++)
    {
        for (int j = 0; j < multi.GetLength(1)-1; j++)
        {

            multi[i, j] = arrayFirst[i, j] * arraySecod[i, j] + arrayFirst[i, j + 1] * arraySecod[i + 1, j];
        }
    }
    return multi;
}
int rowMasFirst = ReadInt("Количество строк  первого массива  >");
int columnMasFirst = ReadInt("Количесвто столбцов первого массива >");
int rowMasSecond = ReadInt("Количество строк второго массива  >");
int columnMasSecond = ReadInt("Количесвто столбцов второго массива >");
int[,] massiveFirst = CreateArray(rowMasFirst, columnMasFirst);
int[,] massiveSecond = CreateArray(rowMasSecond, columnMasSecond);
Print2DArrayMas(massiveFirst);
Print2DArrayMas(massiveSecond);
if (columnMasFirst == rowMasSecond)
{
    Print2DArrayMas(MultiMas(massiveFirst, massiveSecond));
}
else System.Console.Write("Умножение матриц невозможно");
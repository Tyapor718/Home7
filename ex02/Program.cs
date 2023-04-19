//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
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
void PrintArrayMas(int[] array)
{
     System.Console.WriteLine(" Сумма элементов по строкам массива");
    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($"{array[i]}  ");
    }

    System.Console.WriteLine();
}

int[] MinRowSum(int[,] array)
{
    int[] minMassiv = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        minMassiv[i] = sum;
    }
    return minMassiv;
}
int MinRow(int[] arraymin)
{
    int minIndex = 0;
    for (int i = 0; i < arraymin.Length; i++)
    {
        int min = arraymin[0];

        {
            if (arraymin[i] < min)
            {
                min = arraymin[i];
                minIndex = i;
            }
        }
    }
    return minIndex;
}
int rowMas = ReadInt("Количество строк прямоугольного массива массива  >");
int columnMas = ReadInt("Количесвто столбцов прямоугольного массива >");
if (rowMas == columnMas) System.Console.Write("Вы задали не прямоугольный массива");
else
{
    int[,] massive = CreateArray(rowMas, columnMas);
    Print2DArrayMas(massive);
    int[] minimalRow = (MinRowSum(massive));
    PrintArrayMas(minimalRow);
    int index = MinRow(minimalRow);
    System.Console.WriteLine($"Строка с минимальной суммой элементов {index + 1} ");
}




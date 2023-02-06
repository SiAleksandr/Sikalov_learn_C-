// Задайте двумерный массив из целых чисел. Найдите
//среднее арифметическое элементов в каждом столбце.
int [,] GenerateArray()
{
    int [,] array = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void FindAverages (int[,] array)
{
    int columns = array.GetLength(1);
    int[] sumInColumn = new int[columns];
    foreach (int item in sumInColumn)
    {
        sumInColumn[item] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumInColumn[j] = sumInColumn[j] + array[i, j];
        }
    }
    System.Console.WriteLine("Среднее арифметическое каждого столбца по порядку:");
    double averege = 0;
    double rows = Convert.ToDouble(array.GetLength(0));
    for (int n = 0; n < columns; n++ )
    {
        averege = sumInColumn[n] / rows;
        System.Console.Write($"{averege:F2}" + "\t");
    }
    System.Console.WriteLine();
}
int [,] newArray = GenerateArray();
PrintArray(newArray);
FindAverages(newArray);


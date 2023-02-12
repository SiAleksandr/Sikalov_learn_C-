// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check(int lines, int columns)
{
    if (lines < 1 || columns < 1)
    {
        System.Console.WriteLine("Введены недопустимые размеры массива. Дальнейшие действия невозможны.");
        Environment.Exit(1);
    }
}
int[,] GenerateArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
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
int FindMinRow(int[,] array)
{
    int length = array.GetLength(0);
    int[] additionResults = new int[length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        additionResults[i] = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            additionResults[i] += array[i, j];
        }
    }
    int indexMin = 0;
    for (int m = 1; m < additionResults.Length; m++)
    {
        if (additionResults[indexMin] > additionResults[m]) indexMin = m;
    }
    return indexMin + 1;
}
void PrintAnswer(int answer)
{
    System.Console.WriteLine($"Наименьшая сумма элементов в сроке {answer}");
}
int height = InputInt("Введите количество строк в массиве");
int width = InputInt("Введите количество столбцов в массиве");
Check(height, width);
int [,] newArray = GenerateArray(height, width);
PrintArray(newArray);
int row = FindMinRow(newArray);
PrintAnswer(row);

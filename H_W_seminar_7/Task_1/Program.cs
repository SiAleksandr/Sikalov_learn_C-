// Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
double[,] GenerateArray(int max, int m = 3, int n = 4)
{
    Random rnd = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * max;
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}" + "\t");
        }
        System.Console.WriteLine();
    }
}
int maxValue = InputInt("Введите предельно допустимое число в массиве");
double[,] newArray = GenerateArray(maxValue);
PrintArray(newArray);

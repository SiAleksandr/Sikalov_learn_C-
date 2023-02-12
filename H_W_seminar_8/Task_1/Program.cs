//Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы
//каждой строки двумерного массива.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check (int lines, int columns)
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
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array, string indication)
{
    System.Console.WriteLine(indication);
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int [,] ArrayConversion(int[,] array)
{
    int next;
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {

            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                next = j + 1;
                if (array[i, j] < array[i,next])
                {
                    temp = array[i,j];
                    array[i, j] = array[i, next];
                    array[i, next] = temp;
                }
            }
        }

    }
    return array;
}
int height = InputInt("Введите количество строк в массиве");
int width = InputInt("Введите количество столбцов в массиве");
Check (height, width);
int[,] initialArray = GenerateArray(height, width);
PrintArray(initialArray, "Исходный массив");
int[,] newArray = ArrayConversion(initialArray);
PrintArray(newArray, "Получившийся массив");
// Напишите программу, которая заполнит
// спирально квадратный массив.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check(int len)
{
    if (len < 1)
    {
        System.Console.WriteLine("Недопустимое число. Дальнейшие действия невозможны.");
        Environment.Exit(1);
    }
}
int[,] FillResultArray(int size)
{
    int[,] array = new int[size, size];
    int before = 0;
    int after = size - 1;
    int j = 0;
    int i = 0;
    int num = 1;
    array[0, 0] = 1;
    while (num < size * size)
    {
        if ((j < after) && (i == before)) j += 1;
        else if ((i < after) && (j == after)) i += 1;
        else if ((j > before) && (i == after)) j -= 1;
        else if ((i > (before + 1)) && (j == before)) i -= 1;
        if ((i == before + 1) && (j == before))
        {
            before += 1;
            after -= 1;
        }
        num += 1;
        array[i, j] = num;
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
int side = InputInt("Введите число элементов одной стороны квадратного массива");
Check(side);
int[,] matrix = FillResultArray(side);
PrintArray(matrix);

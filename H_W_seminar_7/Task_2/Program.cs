// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
int[,] GenerateArray()
{
    int[,] matrix = new int[5, 7];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-100, 101);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
(int, int) InputIndexes()
{
    System.Console.Write("Введите номер строки -> ");
    int row = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Ведите номер столбца -> ");
    int col = Convert.ToInt32(Console.ReadLine());
    return (row, col);
}
bool CheckIndexes(int[,] matrix, int row, int col)
{
    bool check = true;
    if (row > matrix.GetLength(0) || row <= 0) check = false;
    if (col > matrix.GetLength(1) || col <= 0) check = false;
    return check;
}
void PrintAnswer(bool check, int[,] matrix, int row, int col)
{
    row -= 1;
    col -= 1;
    if (check == true)
    {
        System.Console.WriteLine($"Элемент на этой позиции это {matrix[row, col]}");
    }
    else
    {
        System.Console.WriteLine("В этом массиве нет элемента на такой позиции");
    }
}
int[,] array = GenerateArray();
(int row, int col) = InputIndexes();
bool check = CheckIndexes(array, row, col);
PrintArray(array);
PrintAnswer(check, array, row, col);

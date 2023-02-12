// Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check(int firstValue, int secondValue, int thirdValue)
{
    if (firstValue < 1 || secondValue < 1 || thirdValue < 1)
    {
        System.Console.WriteLine("Введены недопустимые параметры. Дальнейшие действия невозможны.");
        Environment.Exit(1);
    }
}
int[,] CreateMatrix(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int lines = firstMatrix.GetLength(0);
    int columns = secondMatrix.GetLength(1);
    int[,] resultMatrix = new int[lines, columns];
    for (int m = 0; m < lines; m++)
    {
        for (int k = 0; k < columns; k++)
        {
            resultMatrix[m, k] = 0;
            for (int n = 0; n < firstMatrix.GetLength(1); n++)
            {
                resultMatrix[m, k] += firstMatrix[m, n] * secondMatrix[n, k];
            }
        }
    }
    return resultMatrix;
}
void PrintMatrix(int[,] matrix, string indication)
{
    System.Console.WriteLine(indication);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int sideOne = InputInt("Введите количество строк в первой матрице");
int equal = InputInt("Число столбцов в первой равно числу строк во второй. Введитте его");
int sideTwo = InputInt("Введите количество столбцов во второй матрице");
Check(sideOne, equal, sideTwo);
int[,] firstMatrix = CreateMatrix(sideOne, equal);
int[,] secondMatrix = CreateMatrix(equal, sideTwo);
PrintMatrix (firstMatrix, "Первая матрица:");
PrintMatrix (secondMatrix, "Вторая матрица:");
int[,] newMatrix = MatrixMultiplication(firstMatrix, secondMatrix);
PrintMatrix (newMatrix, "Произведение этих матриц:");
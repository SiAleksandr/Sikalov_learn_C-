// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
void DifferenceOfElements()
{
    double[] array = new double[15];
    System.Console.Write("Введите верхний предел значений -> ");
    int maxLimit = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите нижний предел значений -> ");
    int minLimit = Convert.ToInt32(Console.ReadLine());
    int multiplier = 7;
    maxLimit = maxLimit * multiplier;
    minLimit = minLimit * multiplier;
    int element = 0;
    double recycleToDouble = Convert.ToDouble(multiplier);
    for (int i = 0; i < array.Length; i++)
    {
        element = new Random().Next(minLimit, maxLimit);
        array[i] = element / recycleToDouble;
    }
    PrintArray(array);
    double max = MaxOfArray(array);
    double min = MinOfArray(array);
    double diff = max - min;
    System.Console.WriteLine($"Разность между большим и меньшим");
    System.Console.WriteLine($"числлами составляет {diff}");
}
double MaxOfArray(double[] arr)
{
    int len = arr.Length;
    double resultMax = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (resultMax < arr[i]) resultMax = arr[i];
    }
    return resultMax;
}
double MinOfArray(double[] arr)
{
    int len = arr.Length;
    double resultMin = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (resultMin > arr[i]) resultMin = arr[i];
    }
    return resultMin;
}
void PrintArray(double[] arr)
{
    int len = arr.Length;
    int oneRow = 4;              // Это количество чисел в
    int i = 0;                   // строчке (для красоты вывода).
    while (i < len)
    {
        System.Console.Write(arr[i]);
        i += 1;
        if (i % oneRow == 0)
        {
            System.Console.WriteLine();
        }
        else
        {
            if (i != len) System.Console.Write(" ; "); 
        }
    }
    System.Console.WriteLine();
}
DifferenceOfElements();

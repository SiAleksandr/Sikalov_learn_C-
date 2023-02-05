// Найти второй по величине элемент
// массива
int[] FindSecondMax (int[] arr)
{
    int len = arr.Length;
    int max = arr[0];
    int min = arr[0];
    int i = 1;
    while (i < len)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
        i += 1;
    }
    int secondMax = min;
    i = 0;
    while (i < len)
    {
        if (secondMax < arr[i] && max > arr[i]) secondMax = arr[i];
        i += 1;
    }
    int [] arrayWithAnswer = new int[3];
    arrayWithAnswer[0] = secondMax;
    arrayWithAnswer[1] = max;
    arrayWithAnswer[2] = min;
    return arrayWithAnswer;
}
int [] GenerateArray (int len)
{
    System.Console.WriteLine($"Введите один за другим {len} элементов массива:");
    int [] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray (int[] arr)
{
    System.Console.WriteLine("Получился такой массив:");
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine();
}
int InputQuantity()
{
    int len = 0;
    while (len < 2)
    {
        System.Console.Write( "Введите количество элементов -> ");
        len = Convert.ToInt32(Console.ReadLine());
        if (len < 2) System.Console.WriteLine(" Должно быть не менее двух");
    }
    return len;
}
void PrintAnswer (int[] data)
{
    if (data[1] == data[2])
    {
        System.Console.WriteLine("Все элементы равны");
    }
    else
    {
        System.Console.WriteLine($"Второй по величине элемент это {data[0]}");
    }
}
int length = InputQuantity();
int[] array = GenerateArray(length);
PrintArray(array);
int[] savedData = FindSecondMax(array);
PrintAnswer (savedData);
        

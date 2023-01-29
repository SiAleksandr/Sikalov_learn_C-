// Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
void CreateArray()
{
    System.Console.Write("Введите размер массива -> ");
    int lenght = Convert.ToInt32(Console.ReadLine());
    if (lenght < 0) lenght = 0;
    System.Console.Write("Введите максимальное значение его элементов -> ");
    int max = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите минимальное значение его элементов -> ");
    int min = Convert.ToInt32(Console.ReadLine());
    if (max < min)
    {
        System.Console.WriteLine("Максимальнное меньше минимального!");
    }
    else
    {
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            array[i] = new Random().Next(min, max);
        }
        for (int i = 0; i < lenght; i++)
        {
            System.Console.Write($"{array[i]}; ");
        }
        System.Console.WriteLine();
        int answer = HowMany(array);
        System.Console.WriteLine($"Сумма элементов с нечётными индексами -> {answer}");
    }
}
int HowMany (int[] arr)
{
    int count = arr.Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];            
        }
        
    }
    return sum;
}
CreateArray();


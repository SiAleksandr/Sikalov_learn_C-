// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.

void CreateArray()
{
    System.Console.Write("Введите размер массива -> ");
    int lenght = Convert.ToInt32(Console.ReadLine());
    if (lenght < 0) lenght = 0;
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    for (int i = 0; i < lenght; i++)
    {
        System.Console.Write($" {array[i]};");

    }
    System.Console.WriteLine();
    int evenNumbers = CheckArray(array);
    System.Console.WriteLine($"В этом массиве {evenNumbers} чётных чисел");
}
int CheckArray(int[] arr)
{
    int len = arr.Length;
    int sum = 0;
    for (int i = 0; i <= len - 1; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
CreateArray();

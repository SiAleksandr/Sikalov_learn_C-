// Напишите программу, которая выводит массив 
// из 8 элементов, заполненный случайными числами.
void PrintArray()
{
    int[] array = new int[8];
    int quantity = array.Length;
    for (int i = 0; i < quantity; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    for (int k = 0; k < quantity; k++)
    {
        int element = array[k];
        System.Console.Write($"{element}; ");
    }
}
PrintArray();

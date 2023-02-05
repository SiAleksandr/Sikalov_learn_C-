// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
int InputInt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int len)
{
    int[] array = new int[len];
    System.Console.WriteLine("Ниже одно за другим введите сами сисла:");
    for (int i = 0; i < len; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int SearchForPositive(int[] array)
{
    int len = array.Length;
    int counting = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > 0) counting += 1;
    }
    return counting;
}
int quantity = InputInt("Введите количество чисел");
int[] array = GenerateArray(quantity);
int answer = SearchForPositive(array);
System.Console.WriteLine($"Чисел больше нуля было {answer}");

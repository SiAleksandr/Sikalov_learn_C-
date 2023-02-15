// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
int InputInt(string msg)
{
    System.Console.Write(msg + " -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check(int min, int max)
{
    if (max < 0 || min > max)
    {
        System.Console.WriteLine("С такими числами дальнейшие действия невозможны");
        Environment.Exit(1);
    }
}
(int, int, int) AdjustData(int min, int max)
{
    if (min < 0) min = 0;
    int sum = min;
    return (sum, min, max);
}
int SumOfNatural(int sum, int min, int max)
{
    min += 1;
    if (min > max) return sum;
    return sum + SumOfNatural(sum + 1, min, max);
}
int little = InputInt("Введите, от какого числа начинать");
int big = InputInt("Ведите, до какого числа считать");
Check(little, big);
(int sum, int min, int max) = AdjustData(little, big);
int answer = SumOfNatural(sum, min, max);
System.Console.WriteLine($"Сумма всех натуральных чисел в этом интервале это {answer}");
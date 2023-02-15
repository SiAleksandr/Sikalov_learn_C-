// Задайте значения M и N. Напишите программу, которая
// выведет все чётные натуральные числа в
// промежутке от M до N с помощью рекурсии.
int InputInt(string msg)
{
    System.Console.Write(msg + " -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check (int min, int max)
{
    if (max < 1 || min > max)
    {
        System.Console.WriteLine("С такими числами дальнейшие действия невозможны");
        Environment.Exit(1);
    }
}
void ShowEven(int min, int max)
{
    if (min % 2 == 1) min += 1;
    if (min <= 0) min = 2;
    if (min > max) return;
    System.Console.Write($"{min}; ");
    ShowEven(min + 2, max);   
}
int little = InputInt("Введите, от какого числа начать");
int big = InputInt("Введите, до какого числа подняться");
Check(little, big);
ShowEven(little, big);

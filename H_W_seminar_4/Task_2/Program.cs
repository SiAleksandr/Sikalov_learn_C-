// Напишите программу, которая
// принимает на  вход число и выдаёт
// сумму цифр в числе. Реализовать 
// через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void CountDigit()
{
    System.Console.Write("Введите число -> ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while ( num > 0 )
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    System.Console.WriteLine($"Сумма цифр этого будет -> {sum}");
}
CountDigit();

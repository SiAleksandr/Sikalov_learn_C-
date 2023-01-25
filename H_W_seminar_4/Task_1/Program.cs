// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в 
// натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите для него степень -> ");
int powerOfNum = Convert.ToInt32(Console.ReadLine());
void NomberToPower(int num, int pow)
{
    if (pow < 0)
    {
        System.Console.WriteLine("Степень не должна быть отрицательным числом");
    }
    else
    {
        int result = 1;
        for(int i = 1; i <= pow; i++ )
        {
        result = result * num;
        }
System.Console.WriteLine($"Число {num} в степени {pow} это {result}");
    }
}
NomberToPower(number, powerOfNum);
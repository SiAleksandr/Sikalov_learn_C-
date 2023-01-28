// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в 
// натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void PrintAnswer()
{
    System.Console.Write("Введите число -> ");
    int number = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите для него степень -> ");
    int powerOfNum = Convert.ToInt32(Console.ReadLine());
    if (powerOfNum < 0)
    {
        System.Console.WriteLine("Показатель степени не должен быть отрицательным");
    }
    else
    {
        int answer = NomberToPower(number, powerOfNum);
        System.Console.WriteLine($"Число {number} в степени {powerOfNum} это {answer}");
    }
}
int NomberToPower(int num, int pow)
{
    int result = 1;
    for(int i = 1; i <= pow; i++ )
    {
        result = result * num;
    }
    return result;
}
PrintAnswer();
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Введте число, в котором надо найти третью цифру -> ");
int givenNum = Convert.ToInt32(Console.ReadLine());
if (givenNum < 99 && givenNum > -99 )
{
    System.Console.WriteLine("В этом числе нет третьей цифры.");
}
else
{
    int FindDigit3(int N)
    {
        int dig3 = ((N / 10) / 10) % 10;
        if (dig3 < 0)
        {
            dig3 = dig3 * (-1);
        }
        return dig3;
    }
    int thirdDigit = FindDigit3(givenNum);
    System.Console.Write($"Третья цифра числа это {thirdDigit}");
}
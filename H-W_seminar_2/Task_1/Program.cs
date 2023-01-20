//Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает
//вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
System.Console.Write("Ввудите трёхзначное число -> ");
int givenNum = Convert.ToInt32(Console.ReadLine());
if (givenNum > 99 && givenNum < 1000)
{
    int FindDigit2(int x3)
    {
        int dig2 = (x3 / 10) % 10;
        return dig2;
    }
    int answer = FindDigit2(givenNum);
    System.Console.WriteLine($"Вторая цифра этого числа это {answer}");
}
else
{
    System.Console.WriteLine("Это число не подходит");
}
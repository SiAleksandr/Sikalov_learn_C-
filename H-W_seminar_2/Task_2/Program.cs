// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Введте число, в котором надо найти третью цифру -> ");
int givenNum = Convert.ToInt32(Console.ReadLine());
int CountDigits(int k)
{
    int count = 0;
    while (k > 0)
        {
            k = k / 10;
            count +=1;
        }
    return count;
}
if (givenNum > 99 || givenNum < -99)
{
    if (givenNum < 0)
    {
        givenNum = givenNum * (-1);
    }
    int howMany = CountDigits(givenNum);
    howMany = howMany - 3;
    int counter = 0; 
    while (counter < howMany)
    {
        givenNum = givenNum/10;
        counter += 1;
    }
    int answer = givenNum % 10;
    System.Console.Write($"Третья цифра числа это {answer}");
}
else
{
    System.Console.WriteLine("В этом числе нет третьей цифры.");
}
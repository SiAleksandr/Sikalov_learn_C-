//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int GetGivenNumber(int N) 
{
    System.Console.WriteLine("Введите для проверки число -> ");
    N = Convert.ToInt32(Console.ReadLine());
    int Num = N;
    return Num;
}
int firstNum = 24;
int answer = GetGivenNumber(firstNum);
System.Console.WriteLine(answer);
// Пока что это белеберда
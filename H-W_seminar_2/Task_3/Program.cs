// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является
//ли этот день выходным. 
//6 -> да
//7 -> да
//1 -> нет
System.Console.Write("Введите, цифру, обозначающую день недели -> ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number <= 7)
{
    void CheckingWeekend(int day)
    {
        if (day > 5)
        {
            System.Console.WriteLine("Да это же выходной!");
        }   
        else 
        {
            System.Console.WriteLine("Нет уж, это будний день.");
        }    
    }
    CheckingWeekend(number);
}

//Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
//4 -> да; -3 -> нет; 7 -> нет
System.Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
int check = number % 2;
if (check == 0) {
    System.Console.WriteLine("Это чётное число");
}
else {
    System.Console.WriteLine("Это нечётное число");
}
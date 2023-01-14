//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее. 
//a = 5; b = 7 -> max = 7, min = 5
//a = -9 b = -3 -> max = -3, min = -9
System.Console.Write("Введите первое число -> ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число -> ");
int number2 = Convert.ToInt32(Console.ReadLine());
if ( number1 > number2 ) {
    System.Console.WriteLine($"Большее = {number1}; Меньшее = {number2}"); 
}
else {
    if ( numder1 == number2 ) {
        System.Console.WriteLine($"Эти числа равны {number1} = {number2}";
    }
    else {
        System.Console.WriteLine($"Большее = {number2}; Меньшее = {number1}");
    }
}
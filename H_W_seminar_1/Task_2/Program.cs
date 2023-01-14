// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.Write("Введите первое число -> ");
int first = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число -> ");
int second = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третее число -> ");
int third = Convert.ToInt32(Console.ReadLine());
int max = first;
if ( second > first ) {
    max = second;
}
if ( third > max ) {
    max = third;
}    
System.Console.Write($"Наибольшее число это: {max}");

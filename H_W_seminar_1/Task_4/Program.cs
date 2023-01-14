//Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
System.Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1) {
    int count = 0;
    int sum = 0;
    System.Console.WriteLine($"Чётные числа от 0 до {number} это:");
    number = number / 2;
    while ( count < number ) {
        sum = sum + 2;
        System.Console.Write($"{sum}, ");
        count +=1;
    }
}
else {
    System.Console.WriteLine($"Число {number} не подходит");   
}
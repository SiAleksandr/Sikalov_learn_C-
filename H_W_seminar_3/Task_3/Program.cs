// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
System.Console.Write("Введите число -> ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вот таблица кубов чисел от 1 до {num}");
void CubesTable (int N)
{
    int i = 1;
    int cube = 1;
    while (i <= N)
    {
        cube = i * i * i;
        System.Console.Write($"{cube}; ");
        i = i + 1;
    }
}
CubesTable(num);
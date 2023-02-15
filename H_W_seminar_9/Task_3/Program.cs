// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int InputInt(string msg)
{
    System.Console.Write(msg + " -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void Check (int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {
        System.Console.WriteLine("С такими числами дальнейшие вычисления невозможны.");
        Environment.Exit(1);
    }
}
int AckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFunc(m - 1, 1);
    return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}
int argumentM = InputInt("Введите аргумент m");
int argumentN = InputInt("Введите аргумент n");
Check(argumentM, argumentN);
int result = AckermanFunc(argumentM, argumentN);
System.Console.WriteLine($"Результат вычисления функции Аккермана F(m,n) = {result}");
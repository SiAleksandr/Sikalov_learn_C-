// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] GetParameters()
{
    double[] parameters = new double[4];
    System.Console.WriteLine("Первая прямая: y = k1 * x + b1");
    System.Console.Write("Введите k1 -> ");
    parameters[0] = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите b1 -> ");
    parameters[1] = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Вторая прямая: y = k2 * x + b2");
    System.Console.Write("Введите k2 -> ");
    parameters[2] = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите b2 -> ");
    parameters[3] = Convert.ToDouble(Console.ReadLine());
    return parameters;
}
bool CheckParameters(double[] parameters)
{
    bool checkParemeters = true;
    if (parameters[0] == parameters[2]) checkParemeters = false;
    return checkParemeters;
}
void FindAnswer(double[] param)
{
    bool check = CheckParameters(param);
    double[] finalCoordinates = new double[2];
    if (check == true)                                                           // k1 = param[0]; 
    {                                                                            // b1 = param[1];                                                                
        finalCoordinates[0] = (param[3] - param[1]) / (param[0] - param[2]);     // k2 = param[2];
        finalCoordinates[1] = param[0] * finalCoordinates[0] + param[1];         // b2 = param[3];
        System.Console.WriteLine("Координаты точки пересечения:");
        System.Console.WriteLine($"x = {finalCoordinates[0]:F2}");
        System.Console.WriteLine($"y = {finalCoordinates[1]:F2}");                                                                         
    }
    else
    {
        System.Console.WriteLine("Эти прямые параллельны");
    }
}
double[] inputNumbers = GetParameters();
FindAnswer(inputNumbers);

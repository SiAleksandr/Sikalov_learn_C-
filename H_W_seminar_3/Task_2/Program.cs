// Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между
//ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("Введите координаты точки A");
System.Console.Write("X = ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z = ");
int zA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B");
System.Console.Write("X = ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int yB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z = ");
int zB = Convert.ToInt32(Console.ReadLine());
int Modulo(int N)
{
    int modN = 0;
    if (N < 0)
    {
        modN = N * (-1);
    }
    else
    {
        modN = N;
    }
    return modN;
}
int FindMax(int n0, int n1, int n2, int n3, int n4, int n5)
{
    int[] coord = new int[6];
    coord[0] = n0;
    coord[1] = n1;
    coord[2] = n2;
    coord[3] = n3;
    coord[4] = n4;
    coord[5] = n5;
    int maxCoord = coord[0];
    int i = 0;
    while(i < 6)
    {
        if (coord[i] > maxCoord)
        {
            maxCoord = coord[i];
        }
        i++;
    }
    return maxCoord;
}
double LenghtAB(int startXa, int startYa, int startZa, int startXb, int startYb, int startZb)
{
    int modXa = Modulo(startXa);
    int modYa = Modulo(startYa);
    int modZa = Modulo(startZa);
    int modXb = Modulo(startYb);
    int modYb = Modulo(startYb);
    int modZb = Modulo(startZb);
    int max = FindMax(modXa, modYa, modZa, modXb, modYb, modZb);
    int newXa = max + startXa;
    int newYa = max + startYa;
    int newZa = max + startZa;
    int nweXb = max + startXb;
    int newYb = max + startYb;
    int newZb = max + startZb;
    int diffYaYb = newYa - newYb;
    diffYaYb = Modulo(diffYaYb);
    int diffXaXb = newXa - nweXb;
    diffXaXb = Modulo(diffXaXb);
    int diffZaZb = newZa - newZb;
    double gipotenuzaOxOz = Math.Sqrt((diffXaXb * diffXaXb) + (diffZaZb * diffZaZb));
    double ab = Math.Sqrt((gipotenuzaOxOz * gipotenuzaOxOz) + (diffYaYb * diffXaXb));
    return ab;
}
double answer = LenghtAB(xA, yA, zA, xB, yB, zB);
System.Console.Write($"Расстояние от A до B = {answer}");
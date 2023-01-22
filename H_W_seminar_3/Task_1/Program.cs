//Напишите программу, которая принимает на вход
//пятизначное число и проверяет,
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
// Я сделал для любого числа
int CountDigits(int k)     // функция считает, сколько цифр
{                          // в любом числе k 
    int count = 0;
    if (k == 0)
    {
        count = 1;
    }                        
    if (k < 0)
    {
        k = (k * (-1));
    }                            
    while (k > 0)
        {
            k = k / 10;
            count +=1;
        }
    return count;
}
System.Console.Write("Палиндром, или нет это число -> ");
int givenNum = Convert.ToInt32(Console.ReadLine());
int GetDiget(int N, int No)          // Функция определяет, цифру
{                                    // в числе N по номеру её разряда
    if (N < 0)
    {
        N = (N * (-1));
    }                                 
    int count = 0;
    int digit = -1;
    while (count <= No)
    {
        count ++;
        if (count == No)
        {
            digit = N % 10;
            break;
        }
        N = N / 10;
    }
        return digit;
}
bool answer = true;
int lenght = CountDigits(givenNum);
if (lenght == 1)
{
    answer = true;
}
else
{
    int left = -1;
    int right = -1;
    int center = -1;
    int centerDigit = -1;
    int leftDigit = -1;
    int rightDigit = -1;
    int oldLeft = -1;
    int oldRight = -1;
    int i = -1;
    if ((lenght % 2) == 1)
    {
        center = (lenght / 2) +1;
        left = center;
        right = center;
        centerDigit = GetDiget(givenNum, center);
        leftDigit = GetDiget(givenNum, left);
        rightDigit = GetDiget(givenNum, right);
        i = center;
        while (i > 1)
        {
            oldLeft = leftDigit;
            oldRight = rightDigit;
            left = left - 1;
            right = right + 1;
            leftDigit = GetDiget(givenNum, left);
            rightDigit = GetDiget(givenNum, right);
            if ((centerDigit > leftDigit) && (leftDigit == rightDigit) && (leftDigit < oldLeft) && (rightDigit < oldRight))
            {
                answer = true;
            }
            else 
            {
                answer = false;
                break;
            }
            i = i - 1;

        }
        
    }
    else
    {
        left = lenght / 2;
        right = (lenght / 2) + 1;
        leftDigit = GetDiget(givenNum, left);
        rightDigit = GetDiget(givenNum, right);
        i = left;
        while (i > 1)
        {
            oldLeft = leftDigit;
            oldRight = rightDigit;
            left = left - 1;
            right = right + 1;
            leftDigit = GetDiget(givenNum, left);
            rightDigit = GetDiget(givenNum, right);
            if ((leftDigit == rightDigit) && (leftDigit < oldLeft) && (rightDigit < oldRight))
            {
                answer = true;
            }
            else
            {
                answer = false;
                break;
            }
            i = i - 1;
        }
    }
}   
if (answer == true)
{
        System.Console.WriteLine("Да, палиндром");   
}
else
{                                                       
    System.Console.WriteLine("Нет, не палиндром");
}
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(int number)
{
    int num = number;
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    } 
    return result == number;
}

Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (Palindrom(num))
{
    Console.WriteLine($"{num} yes");
}
else
{
    Console.WriteLine($"{num} no");
}
*/
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LineLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double L1 = x1 - x2;
    double L2 = y1 - y2;
    double L3 = z1 - z2;
    double result = Math.Sqrt(Math.Pow(L1, 2)+Math.Pow(L2, 2)+Math.Pow(L3, 2));
    return result;
    
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Line Length: "+ Math.Round(LineLength(x1, y1, z1, x2,y2, z2), 2));
*/
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Print(int N)
{
    int i=1;
    while (i <=N)
    {
        Console.Write(Math.Pow(i, 3) +" " );
        i++;
    }
}

Console.WriteLine("input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
Print(N);

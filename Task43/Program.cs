// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте значение b1: ");
double userInputB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение k1: ");
double userInputK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение b2: ");
double userInputB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение k2: ");
double userInputK2 = Convert.ToInt32(Console.ReadLine());

void Check(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны");
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
}

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round (x, 2);
    y = Math.Round (y, 2);
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: X = {x}, Y = {y}");
    
}

Check(userInputB1, userInputK1, userInputB2, userInputK2);
CrossPoint(userInputB1, userInputK1, userInputB2, userInputK2);

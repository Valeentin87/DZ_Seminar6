// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("введите коэффициент b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите коэффициент k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите коэффициент b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите коэффициент k2");
double k2 = Convert.ToDouble(Console.ReadLine());
string intersection = СoordinatesIntersection(b1, k1, b2, k2);
Console.WriteLine(intersection);
string СoordinatesIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2  & b1 != b2)
    { 
        return "линии с заданными параметрами не пересекаются, параллельны друг другу";
    }
    else if (b1 == b2 & k1 == k2)
    {
        return "линии совпадают";
    }
    double X = (b2 - b1)/(k1 - k2);
    double Y = (k1*(b2 - b1)/(k1 - k2) + b1);
    string X1 = Convert.ToString(X);
    string Y1 = Convert.ToString(Y);
    string answer = "(" + X1 + ";" + Y1 + ")";
    return answer; 
}

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"IntersectionPoint is ({x}; {y})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    IntersectionPoint(b1, k1, b2, k2);
}

else if (k1 == k2)
{
    Console.Write("ERROR! k1 = k2! Input new!");
}
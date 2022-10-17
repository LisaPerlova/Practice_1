// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Range (int xc1, int yc1, int xc2, int yc2)
{
    double diffX = Math.Pow((xc2 - xc1), 2);
    double diffY = Math.Pow((yc2 - yc1), 2);
    double sumXY = diffX + diffY;
    double rangeXY = Math.Sqrt(sumXY);
    return Math.Round(rangeXY, 2, MidpointRounding.ToZero);
}
double result = Range (x1, y1, x2, y2);
Console.WriteLine(result);
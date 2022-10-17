// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// Console.Write("Введите X: ");
// int dotx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int doty = Convert.ToInt32(Console.ReadLine());
// if (dotx > 0 & doty > 0) 
// {
//     Console.WriteLine("1 четверть");
// }
// else if (dotx < 0 & doty > 0) 
// {
//     Console.WriteLine("2 четверть");
// }
// else if (dotx < 0 & doty < 0) 
// {
//     Console.WriteLine("3 четверть");
// }
// else if (dotx > 0 & doty < 0) 
// {
//     Console.WriteLine("4 четверть");
// }
// else Console.WriteLine("Число не может быть равно 0");


Console.Write("Введите X: ");
int dotx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int doty = Convert.ToInt32(Console.ReadLine());
int Quarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
int quarter = Quarter(dotx, doty);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти -> {quarter}"
                            : "Введены неккоректные координаты";
Console.WriteLine(result);                            
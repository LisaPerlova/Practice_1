// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Напишите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle (int num1, int num2, int num3)
{
    return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1);
}
bool triangle = Triangle(number1, number2, number3);
if (triangle) Console.WriteLine("Такой треугольник может существовать");
else Console.Write("Такой треугольник НЕ может существовать");

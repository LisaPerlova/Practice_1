// Программа, принимающая на вход 2 числа и проверяет, являеьсчя ли одно число квадратом другого:
// 5, 25 -> да, 25, 5 -> да,..

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool CheckNumber (int number1, int number2)
{
    int min = number1;
    int max = number2;
    if (number1 > number2)
    {
        min = number2;
        max = number1;
    }
    return min * min == max;
}

bool result = CheckNumber(number1, number2);
if (result) Console.Write("Да");
else Console.Write("Нет");



// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// bool CheckNum(int num1, int num2)
// {
//     int a = num1 * num1;
//     int b = num2 * num2;
//     return  num1 == b | num2 == a;
// }
// bool result = CheckNum(number1, number2);
// if (result) Console.WriteLine("Да");
// else Console.WriteLine("Нет");
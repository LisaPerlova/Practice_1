// Программа, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else 
// {
//     int part = firstNumber % secondNumber;
//     Console.WriteLine($"Не кратно, остаток {part}");
// }



Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool Division (int a, int b)
{
    int div = a % b;
    return div == 0;
}
bool result = Division(firstNumber, secondNumber);
if (result) Console.WriteLine("Да");
else {
    int part = firstNumber % secondNumber;
    Console.WriteLine($"Нет, остаток от деления: {part}");
}
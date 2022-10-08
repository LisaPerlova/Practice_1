//Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Кратно 7 и 23");
// }
// else Console.WriteLine("Не кратно 7 и 23");


bool CheckingNumber (int number, int div1, int div2)
{
    return number % div1 == 0 && number % div2 == 0;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = CheckingNumber(num, 7, 23);
if (result)
{
    Console.Write("Да");
}
else Console.Write("Нет");



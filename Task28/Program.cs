// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
long Factorial (long num)
{
    long factorial = 1;
    int i;
    for (i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                factorial = factorial * i;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Переполнение типа!");
            break;
        }
        
    }
    Console.WriteLine($"Факториал числа {i - 1} -> {factorial}");
    return factorial;
}
long fact = Factorial (number);
// Console.WriteLine($"Произведение чисел от 1 до {number} -> {fact}");
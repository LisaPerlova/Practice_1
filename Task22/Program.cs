// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// while (count <= num)
// {
//     Console.WriteLine($"{count} -> {count*count}");
//     count++;
// }
    


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= num)
// {
//     Console.WriteLine(Square(count));
//     count++;
// }
// string Square (int number)
// {
//     return ($"{number} -> {number * number}");
// }


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Square (num);
// void Square (int number)
// {
//     int count = 1; 
//     while (count <= number)
//     {
//         int square = count * count;
//         Console.WriteLine($"{count}   {square}");
//         count++;
//     }
// }


void SquareTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица квадратов чисел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index, 4}|{Math.Pow(index, 2), 4}|");
        index++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SquareTable (number);

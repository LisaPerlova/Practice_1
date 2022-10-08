// Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа: 456 -> 46.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100-999: {number}");
int FewDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}
int result = FewDigit (number);
Console.WriteLine($"{number} -> {result}");


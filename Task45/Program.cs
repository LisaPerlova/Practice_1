// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = Fibonacci(num);
PrintArray(arr);
int[] newArr = CopyArray(arr);
PrintArray(newArr);


// Второй варинат:
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void Fibonacci(int num)
// {
//     int firstNumber = 0;
//     int secondNumber = 1;
//     Console.Write($"{firstNumber} {secondNumber} ");
//     for (int i = 0; i < num - 2; i++)
//     {
//         int nextNumber = firstNumber + secondNumber;
//         Console.Write($"{netNumber}");
//         firstNumber = secondNumber;
//         secondNumber = nextNumber;
//     }
// }

// Fibonacci(number);
﻿// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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
int[] GetSumPositiveNegativeElem (int[] array)
{
    int sumNegative = default;
    int sumPositive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    // int[] result = new int[2]; // строку 35 можно переписать как int[] result = {sumNegative, sumPositive}, а 36-37 убрать
    // result[0] = sumNegative;
    // result[1] = sumPositive;
    // return result;
    return new int[] {sumNegative, sumPositive};
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] result = GetSumPositiveNegativeElem(arr);
Console.WriteLine($" Сумма положительных чисел = {result[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {result[0]}");
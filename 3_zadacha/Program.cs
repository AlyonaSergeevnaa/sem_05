﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("razmer massiva = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("massiv: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int s = 0; s < numbers.Length; s++)
{
    if (numbers[s] > max)
        {
            max = numbers[s];
        }
    if (numbers[s] < min)
        {
            min = numbers[s];
        }
}

Console.WriteLine($"maximalnoe = {max}, minimalnoe = {min}");
Console.WriteLine($"raznitsa = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
  
    Console.WriteLine();
}
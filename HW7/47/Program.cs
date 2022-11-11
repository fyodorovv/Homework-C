﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите кол-во строк:");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine());
double [,] array = new double [rows,columns];
GetArray(array);
PrintArray(array);

void GetArray(double[,] array)
{
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }   
    }

}
void PrintArray ( double [,] arrray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);      
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);       
Console.Write($"Число {a} в степени {b} равно {GetXZFunction( b)} ");

int GetXZFunction(int d)
{
  
  int result = 1;                                                   
for(int i = 0; i < b; i++)
  { 
  result = result * a;  
  }
return result;
}


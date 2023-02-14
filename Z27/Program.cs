// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!); 
Console.Write($"Сумма цифр в числе {a} равна {GetSum( a)} ");

int GetSum(int a)
{
  int sum = 0;
int count = 0;
if(a < 0)
a *= (-1);
while(a > 0)
  {
 count = a % 10;     
//  Console.WriteLine(count);
 sum += count;
//  Console.WriteLine(sum);
 a = a/10;
//  Console.WriteLine(a); 
  }
return sum;
}

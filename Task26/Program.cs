// Задача 26: Напишите программу, которая принимает 
//на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
/*
int NumName (int num)
{
  int count = 0;
  while (num > 0)
  {
    num = num / 10;
    count++;
  }
  return count;
}
Console.WriteLine(NumName (num));
*/

int FindCount(int num)
{
  int count = 0;
  if (num < 0) num = -num;

  while (num > 0)
  {
    num = num / 10;
    count++;
  }
  return count;
}
int result = FindCount(num);
Console.WriteLine($"{num} => {result}"); 
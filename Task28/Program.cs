// Задача 28: Напишите программу, которая 
// принимает на вход число  и выдает
// произведение чисел от 1 до N.
 // 4 -> 24
 // 5 -> 120
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int MakeFactorial(int num)
{
  int factorial = 1;
  for (int i = 1; i <= num; i++)
  {
    factorial *= i;
  }
  return factorial;
}
int result = MakeFactorial(number);
System.Console.WriteLine($"{number} => {result}");
*/

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial (int numb)
{
  int fact = numb;
  while (numb > 1)
  {
    fact = fact * (numb - 1);
    numb --;
  }
  return fact;
}
int Factorial2 (int num)
{
  int fact2 = 1;
  for (int i = 1; i <= num; i++)
  {
    fact2 = fact2*i;
  }
  return fact2;
}
int factorial = Factorial (number);
Console.WriteLine (factorial);



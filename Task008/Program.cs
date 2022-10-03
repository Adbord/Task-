//Задача 17. Напишите программу, 
// 1. которая принимает на вход координаты точки (X и Y),
// 2. причем X 0 и Y 0 и 
// 3. выдает номер четверти плоскости, в которой 
// находится эта точка.

/*
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x  = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Console.ToInt32(Console.ReadInt());

int Quarter (int xc, int yc)
{
  if(xc > 0 && yc > 0) return 1;
  if(xc < 0 && yc > 0) return 2;
  if(xc < 0 && yc < 0) return 3;
  if(xc > 0 && yc < 0) return 4;
  return 0;
}
*/
// double num = 3.09987565; // 3.09
// double numRound = math.Round(num, 2, MidpointRounding.Tozero);
// System.Console.WriteLine(numRound);


// Задача 20. Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// 3. выводит результат
// А (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Задача 22. Напишите программу, которая
// принимает на вход (N) и выдает таблицу
// квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4


/*
Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int numAX = Convert.ToInt32(Console.ReadLine());
Console.Write(" Y: ");
int numAY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int numBX = Convert.ToInt32(Console.ReadLine());
Console.Write(" Y: ");
int numBY = Convert.ToInt32(Console.ReadLine());

double LengthLine (int ax, int ay, int bx, int by)
{
  if (ay == by && ax == bx) return 0;
  int x = bx - ax;
  int y = by - ay;
return Math.Sqrt(x*x + y*y);
}

double LengthAB = LengthLine(numAX, numAY, numBX, numBY);
double Length = Math.Round(LengthAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({numAX}, {numAY}); B ({numBX}, {numBY}) -> {Length}");
*/

Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

int  counter = 1;

string StringofInSqure (int num)
{
  return $"{num} {num*num}";
}

while (counter <= numX)
{
  Console.WriteLine(StringofInSqure(counter));
  counter++;
}
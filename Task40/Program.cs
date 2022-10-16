// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.


Console.Write("Введите длину первой стороны: ");
int sizeA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int sizeВ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int sizeC = Convert.ToInt32(Console.ReadLine());

bool IsTriangleReal(int nA, int nB, int nC)
{
  bool result = true;
  if ((nA + nB < nC) || (nA + nC < nB) || (nC + nB < nA)) result = false;
return result;
}

if (IsTriangleReal(sizeA, sizeВ, sizeC)) Console.Write("треугольник с такими сторонами может существовать");
else Console.Write("треугольник с такими сторонами не может существовать");

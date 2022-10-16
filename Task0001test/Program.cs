/*Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
*/
/*
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} */
/*
 int a, i, n, sum = 0, sumo = 0;
            int[] m = new int[100];
 
            Random rand = new Random();
            n = 11;
            Console.WriteLine("Исходный массив");
            for (i = 0; i < n; i++)
            {
                m[i] = rand.Next(0, 50);
                Console.Write(m[i] + " ");
            }
 
            var min = m[0];
            var max = m[0];
 
            for (i = 0; i < n; i++)
            {
                if (m[i] < min)
                {
                    min = m[i];
                }
                else if (m[i] > max)
                {
                    max = m[i];
                }
            }
            Console.WriteLine("\nМинимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            for (i = 0; i < n; i++)
            {
                Console.Write(m[i] + " ");
            }
            Console.ReadKey();
            */ 
            /*
            string secretMessage = "Секретное сообщение";
string password = "PassWord";
int attempts = 3;

Console.WriteLine($"Колличество попыток {attempts}");
string checkPass = ReadInput("Введите пароль: ");


for (int i = 1; i <= attempts; i++)
{
    if (checkPass == password)
    {
        Console.WriteLine($"Пароль верный! {secretMessage}");
        break;
    }
    else if (i == attempts)
    {
        Console.WriteLine("Колличество попыток израсходованно");
        break;
    }
    else
    {
        Console.WriteLine($"Пароль неверный! Осталось попыток: {attempts - i} ");
        checkPass = ReadInput("Введите пароль: ");
    }
}


// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}
*/

/*
double numPow (double num = 1, int n = 0)
{
    double result = 1;
    for(int i = 0; i < n; i++) {result *= num;}
    return result;
}

Console.WriteLine("Выедите число");
double number = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую необходимо возвести число");
int exp = int.Parse(Console.ReadLine());

Console.WriteLine(numPow(number, exp));
*/
/*
//Console.Clear();
//Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");
int[] numbers = new int[5];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
*/ 

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Вещественные числа — это числа, у которых есть дробная часть (она может быть нулевой).
// Они могут быть положительными или отрицательными.
// Примеры: 15, 56.22, 0.0, -232336.11

Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
CreateArrayRndInt(number);
Console.WriteLine("массив: ");
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int а = 0; а < number.Length; а++)
{
  if (number[а] > max)
  {
    max = number[а];
  }
  if (number[а] < min)
  {
    min = number[а];
  }
}

Console.WriteLine($"Максимальный {number.Length} элемент. MaxValue = {max}, MinValue = {min}");
Console.WriteLine($"Разница составляет -> {max - min}");

void CreateArrayRndInt(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}





            
  
// // принимает на вход число а и выдает сумму чисел от от 1 до А
// //7 - - 28
// //4 -- 10
// int number = GetNumber();
// Console.WriteLine ($"Sum is: {Sum(number)}");


// int GetNumber()
// {
// System.Console.WriteLine("input number:");
// int number = Convert.ToInt32(Console.ReadLine());
// return number;
// }

// int Sum(int a)  // название функции всегда с большой буквы. 
// //всегда вносим тип введения
// {
// int result = 0;
// for (int i = 1; i <= a; i++)
// {
//   result += i; //result + i
// }
//   return result; // прописываем что возвращаем
// }



//  задача 26 напишите программу которая принмает на вход число и 
//выдает количество цифр в числе 456 --3 6699 - 4 


// HowMany();
// System.Console.WriteLine();
// Production();


// long HowMany()
// {
// System.Console.WriteLine("Введите число:");
// long num = Convert.ToInt64(Console.ReadLine());
// long i = 0;
// while (num > 0)
// {
//   num/=10;
//   i++;

//   }
// Console.WriteLine($"В числе количество цифр: {i}");
// return i;
// }

// //задача 28 принимает на вход число н и выдает произведение чисел от 1 до н
// long Production()
// {
// System.Console.WriteLine("Введите число:");
// long N = Convert.ToInt64(Console.ReadLine());
// long j = 1;
// long res = j;
// while (j <= N)
// {
//   res=res*j;
//   j++;
// }
// Console.WriteLine($"Произведение чисел = {res}");
// return res;
// }


// вариант от группы задача 26
// Task1();
// System.Console.WriteLine();
// Task2();
// System.Console.WriteLine();
Task3();

#region // для сворачивания задачи 26
static void Task1 () 
{
int number = Prompt("Введите число: ");
Count (number);
}
static int Prompt(string message)
{
System.Console.WriteLine("Введите число: ");
int result = Convert.ToInt32(Console.ReadLine());
return result;
}
static void Count (int number)
{
char [] array = number.ToString().ToCharArray();
Console.WriteLine ($"Количество цифр в числе: {array.Length}");
}
#endregion

#region // для сворачивания задачи 2
static void Task2()
{
  int number = Prompt("Введите число: ");
int result = MultiPly (number);
Console.WriteLine ($"Произведение чисел: {result}");
}

static int MultiPly (int number)
{
  int result = 1;
  for (int i = 1; i<= number; i++)
{result *= i;}
  return result;
}
#endregion


// выводит массив из 8 элементов заполненный нулями и единицами в случайном порядке

#region
static void Task3()
{
Random rran = new Random();
int [] array = new int [8];
// var str = string.Join(" ", array);

for (int i = 0; i <array.Length; i++)
{
  array [i] = rran.Next (0,2);
}
var str = string.Join(" ", array); // вывести массив одной строкой без цикла
Console.WriteLine ($"Массив из 8 случайных элементов: {str}");
}
#endregion

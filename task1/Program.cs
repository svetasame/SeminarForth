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

// int HowMany()
// {
// System.Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while (num > 0)
// {
//   num/=10;
//   i++;

//   }
// Console.WriteLine($"В числе количество цифр: {i}");
// return i;
// }

// задача 28 принимает на вход число н и выдает произведение чисел от 1 до н

Production();
int Production()
{
System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int j = 1;
int res = j;
while (j <= N)
{
  res=res*j;
  j++;
}
Console.WriteLine($"Произведение чисел = {res}");
return res;
}
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

int res = HowMany();
Console.WriteLine($"В числе количество цифр: {res}");
  
  int HowMany()
{
System.Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int i = 0;
while (num > 0)
{
  num/=10;
  i++;
  }
return i;
}
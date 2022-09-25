// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
/*
Console.WriteLine ("Введи первое число: ");
int number = int.Parse (Console.ReadLine());
Console.WriteLine ("Введи второе число: ");
int number2 = int.Parse (Console.ReadLine());
if (number>number2)
{
    Console.WriteLine ("Первое число больше второго числа, а второе число меньше первого числа");
}
else if (number<number2)
{
  Console.WriteLine ("Второе число больше первого числа, а первое число меньше второго числа");  
}
*/



// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
Console.WriteLine ("Введи первое число: ");
int number = int.Parse (Console.ReadLine());
Console.WriteLine ("Введи второе число: ");
int number2 = int.Parse (Console.ReadLine());
Console.WriteLine ("Введи третье число: ");
int number3 = int.Parse (Console.ReadLine());
int max = number;
if (max < number2) max = number2;
if (max < number3) max = number3;
Console.WriteLine ($"Максимальное из трех чисел {max}");
*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.WriteLine ("Введи первое число: ");
int number = int.Parse (Console.ReadLine());
if (number%2 ==0)
{
Console.WriteLine ("Число четное");
}
else
{
    Console.WriteLine ("Число нечетное");
}
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8-> 2, 4, 6, 8
/*
Console.WriteLine ("Введи число N: ");
int N = int.Parse (Console.ReadLine());
int a = 1;
Console.WriteLine ("Все четные числа в данном промежутке: ");
while (a <= N)
{
  if (a % 2 ==0)
  {
     Console.Write($"{a} ");
  }
a++;
}
Console.WriteLine ();
*/


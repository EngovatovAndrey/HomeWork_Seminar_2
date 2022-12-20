// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

WriteLine("Введите трехзначное число - ");
int number = Convert.ToInt32(ReadLine());
int digit = number % 10;
    
WriteLine(Math.Abs(number) > 999 || Math.Abs(number) < 100?     
     "Третьей цифры нет": $"{Math.Abs(digit)}");   


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1

Console.Write("Введи трёхзначное число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
string UserString = Convert.ToString(UserNumber);
Console.WriteLine("Вторая цифра этого числа -> "+ UserString[1]);

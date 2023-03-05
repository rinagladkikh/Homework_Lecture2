// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введи число:");
int UserNumber = int. Parse(Console. ReadLine());
string UserString = Convert.ToString(UserNumber);

if(UserString.Length > 2){
    Console.WriteLine("Третья цифра этого числа -> " + UserString[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}


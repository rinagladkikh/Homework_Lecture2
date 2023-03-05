// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозначающее день недели: ");
int UserNumber = int. Parse(Console. ReadLine () !);

if(UserNumber < 6 || UserNumber>1){
    Console.WriteLine("Это будний день -> нет");
 }
  else if (UserNumber == 6 || UserNumber == 7) {
    Console.WriteLine("Это выходной -> да");
  }
else if(UserNumber >7 || UserNumber <1 ){
    Console.WriteLine("Это не день недели");
}




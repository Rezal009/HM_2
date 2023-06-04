// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6
Console.Write("Введи число: ");
int A = Convert.ToInt32(Console.ReadLine());
string AText = Convert.ToString(A);
if (AText.Length > 2)
{
    Console.WriteLine("Третья цифра: " + AText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}

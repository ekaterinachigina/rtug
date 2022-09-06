// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());

if (number1 == 7 ^ number1 == 6)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
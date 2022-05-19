// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.


Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
num = num.Remove(0,1);
num = num.Remove(1,1);
Console.WriteLine(num);
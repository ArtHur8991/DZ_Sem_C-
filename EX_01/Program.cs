////Задача 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
int num1= num / 10 % 10;

Console.WriteLine(num);
Console.Write(num1);


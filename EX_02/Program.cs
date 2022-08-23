// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = new Random().Next(1000, 10000);
int num1= num % 10;

if (num /100 == 0)
{
    Console.WriteLine(num);
    Console.WriteLine("-> третьей цифры нет");
}
else if (num / 1000 > 0)
{
    Console.WriteLine(num);
    Console.WriteLine("третья цифра -> " + num / 10 % 10);
}
else
{
    Console.WriteLine(num);
    Console.WriteLine("третья цифра -> " + num1);
}



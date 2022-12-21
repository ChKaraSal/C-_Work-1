Console.WriteLine("Задача №1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее?");


Console.WriteLine("   Введи a: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи b: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine("a больше b");
}
else
{
    if (num1 < num2)
    {
        Console.WriteLine("b больше a");
    };
};

Console.WriteLine("Задача №2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел?");


Console.WriteLine("   Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи третье число: ");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if (max < number3)
{
    max = number1;
}
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
   max = number3;
}
Console.WriteLine($"максимальное число = {max}");

Console.WriteLine("Задача №3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)?");


Console.WriteLine("   Введи число: ");

int number=int.Parse(Console.ReadLine()!);
if(number%2==0)
{
    Console.WriteLine("Чётное число");
}
else 
{
    Console.WriteLine("Нечётное число") ;
}


Console.WriteLine("Задача №4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N?");

Console.WriteLine("   Введи число N: ");
int N = int.Parse(Console.ReadLine()!);
int index = 1;
while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.WriteLine($"{index}");
    }
    index++;
} 
    

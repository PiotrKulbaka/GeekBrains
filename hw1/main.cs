using System;

public class EntryPoint
{
    public static int max(int a, int b)
    {
        return a > b ? a : b;
    }

    public static int min(int a, int b)
    {
        return a < b ? a : b;
    }

    public static int read_int()
    {
        int number;
        for (;;) {
            if (int.TryParse(Console.ReadLine(), out number)) {
                return number;
            } else {
                Console.WriteLine("Please enter the integer number, and press 'enter'.");
            }
        }
    }
    
    public static void task2()
    {
        /*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее*/
        Console.WriteLine("Task 2:");
        Console.WriteLine("Enter two numbers:");
        int a = read_int();
        int b = read_int();
        Console.WriteLine("max = {0}\nmin = {1}", max(a, b), min(a, b));
    }
    
    public static void task4()
    {
        /*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/
        Console.WriteLine("Task 4:");
        Console.WriteLine("Enter three numbers:");
        int a = read_int();
        int b = read_int();
        int c = read_int();
        Console.WriteLine("max = {0}", max(max(a, b), c));
    }

    public static void task6()
    {
        /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
        Console.WriteLine("Task 6:");
        Console.WriteLine("Enter a number:");
        int a = read_int();
        Console.WriteLine("Number {0} is {1}", a, ((a % 2) == 0 ? "even": "odd"));
    }
    
    public static void task8()
    {
        /*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
        Console.WriteLine("Task 8:");
        Console.WriteLine("Enter a number:");
        int n = read_int();
        Console.WriteLine("Even numbers:");
        for (int i = 2; i <= n; i+= 2) {
            Console.Write("{0}; ", i);
        }
    }
    
    public static void Main(string[] args)
    {
        task2();
        task4();
        task6();
        task8();
    }
}

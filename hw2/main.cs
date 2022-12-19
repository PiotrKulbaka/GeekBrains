using System;

class EntryPoint
{
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
    
    public static String number_to_ordinal_word(int num)
    {
        switch (num) {
        case 1:
            return "first";
        case 2:
            return "second";
        case 3:
            return "third";
        case 4:
            return "fourth";
        case 5:
            return "fifth";
        case 6:
            return "sixth";
        case 7:
            return "seventh";
        default:
            return "ERROR";
        }
    }
    
    public static void task10()
    {
        /* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
        * показывает вторую цифру этого числа. */
        Console.WriteLine("Task 10:");
        Console.WriteLine("Enter a three digits number:");
        int num = read_int();
        if (!(Math.Abs(num) > 99 && Math.Abs(num) < 1000)) {
            Console.WriteLine("Incorrect number {0}.", num);
            return;
        }
        int second_digit = Math.Abs((num / 10) % 10);
        Console.WriteLine("The second digit is {0}.", second_digit);
    }
    
    public static void task13()
    {
        /* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
        * что третьей цифры нет. */
        Console.WriteLine("Task 13:");
        Console.WriteLine("Enter a number:");
        int num = read_int();
        if (Math.Abs(num) < 100) {
            Console.WriteLine("The number {0} don't have the third digit.", num);
            return;
        }
        int third_digit = Math.Abs((num / 100) % 10);
        Console.WriteLine("The third digit is {0}.", third_digit);
    }
    
    public static void task15()
    {
        /* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
        * и проверяет, является ли этот день выходным. */
        Console.WriteLine("Task 15:");
        Console.WriteLine("Enter a digit the number of the day of the week:");
        int num = read_int();
        if (!(num >= 1 && num <= 7)) {
            Console.WriteLine("Incorrect number {0}.", num);
            return;
        }
        Console.WriteLine("The {0} day of the week is {1}.", number_to_ordinal_word(num), (num == 6 || num == 7 ? "weekend" : "weekday"));
    }
    
    static void Main()
    {
        task10();
        task13();
        task15();
    }
}

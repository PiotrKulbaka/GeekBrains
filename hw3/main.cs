/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class vec3
{
    public vec3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public float length_to(vec3 v)
    {
        float dx = x - v.x;
        float dy = y - v.y;
        float dz = z - v.z;
        return (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
    
    public float x;
    public float y;
    public float z;
};

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
    
    public static float read_float()
    {
        float number;
        for (;;) {
            if (float.TryParse(Console.ReadLine(), out number)) {
                return number;
            } else {
                Console.WriteLine("Please enter the floating point number, and press 'enter'.");
            }
        }
    }
    
    public static vec3 read_vec3()
    {
        Console.Write("x = ");
        float x = read_float();
        Console.Write("y = ");
        float y = read_float();
        Console.Write("z = ");
        float z = read_float();
        return new vec3(x, y, z);
    }
    
    public static void task19()
    {
        /* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом */
        Console.WriteLine("Task 19:");
        Console.WriteLine("Enter a five digits number:");
        int val = read_int();
        int input_number = val;
        if (!(val >= 10000 && val < 100000)) {
            Console.WriteLine("The number must be positive and five digits.");
            return;
        }
        int first = val % 10;
        val /= 10;
        int second = val % 10;
        val /= 100;
        bool is_palindrom = (second == (val % 10)) && (first == (val / 10));
        Console.WriteLine("The number {0} is {1}palindrom.", input_number, (is_palindrom ? "" : "not "));
    }
    
    public static void task21()
    {
        /* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в
        3D пространстве. */
        Console.WriteLine("Task 21:");
        Console.WriteLine("Enter the first 3D point:");
        vec3 a = read_vec3();
        Console.WriteLine("Enter the second 3D point:");
        vec3 b = read_vec3();
        Console.WriteLine("The length between two points is: {0}", a.length_to(b));
    }
    
    public static void task23()
    {
        /* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */
        Console.WriteLine("Task 23:");
        Console.WriteLine("Enter the number:");
        int n = read_int();
        Console.WriteLine("Cube table:");
        for (int i = 1; i <= n; i++) {
            Console.Write("{0}{1}", i * i * i, (i != n ? ", " : "\n"));
        }
    }
    
    static void Main()
    {
        task19();
        task21();
        task23();
    }
}

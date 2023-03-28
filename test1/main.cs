using System;

public class HelloWorld
{
    private static string[] get_string_list()
    {
        return new string[] {"Hello", "world", "!", "This", "is", "test", "on", "geegbrains", "123"};
    }
    
    private static void print_string_list(string[] list)
    {
        for (int i = 0; i < list.Length; i++) {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
    
    private static string[] get_strings_by_length_less_or_equal_three(string[] list)
    {
        int needed_size = 0;
        for (int i = 0; i < list.Length; i++) {
            needed_size += Convert.ToInt32(list[i].Length <= 3);
        }
        string[] output_list = new string[needed_size];
        int n = 0;
        for (int i = 0; i < list.Length; i++) {
            if (list[i].Length <= 3) {
                output_list[n++] = list[i];
            }
        }
        return output_list;
    }
    
    public static void Main(string[] args)
    {
        string[] input_list = get_string_list();
        Console.WriteLine("Input array:");
        print_string_list(input_list);
        string[] output_list = get_strings_by_length_less_or_equal_three(input_list);
        Console.WriteLine("Output array:");
        print_string_list(output_list);
    }
}

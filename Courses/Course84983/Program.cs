// See https://aka.ms/new-console-template for more information

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк n");
        int n = Console.Read();
        string[] Array_Str = new string[n];
        Console.WriteLine("Введите строку ");
        //...
        Console.ReadKey();
    }
}
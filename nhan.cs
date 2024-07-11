using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số thứ nhất:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai:");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = Multiply(a, b);
        Console.WriteLine($"Kết quả của {a} nhân {b} là {result}");
    }
    static int Multiply(int x, int y)
    {
        return x * y;
    }
}
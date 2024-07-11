using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        string input1 = Console.ReadLine();
        double a = double.Parse(input1);
        Console.Write("Nhập số thứ hai: ");
        string input2 = Console.ReadLine();
        double b = double.Parse(input2);
        double result = a - b;
        Console.WriteLine("Kết quả của " + a + " - " + b + " = " + result);
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        string input1 = Console.ReadLine();
        if (!double.TryParse(input1, out double a))
        {
            Console.WriteLine("Giá trị nhập không hợp lệ.");
            return;
        }
        Console.Write("Nhập số thứ hai: ");
        string input2 = Console.ReadLine();
        if (!double.TryParse(input2, out double b))
        {
            Console.WriteLine("Giá trị nhập không hợp lệ.");
            return;
        }
        double result = a - b;
        Console.WriteLine("Kết quả của " + a + " - " + b + " = " + result);
    }
}
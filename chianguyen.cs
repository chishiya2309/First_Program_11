using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotient
{
    internal class Chianguyen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap vao 2 so a va b: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int quotient = a / b;
            Console.WriteLine("Tong cua 2 so a va b vua nhap la: " + quotient);
        }
    }
}

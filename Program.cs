using System;
using System.Buffers.Text;

namespace Line_Comparison
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Line\r\nComparison Computation **** ");
            
            double length = read();
            Console.WriteLine("Length of line " + length);
        
        }

        static double read()
        {
            Console.WriteLine("****enter first two number (x1, y1) co-ordinates for point one  ");
            Console.WriteLine("enter x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter y2");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("****enter first two number (x2, y2) co-ordinates for point two  ");
            Console.WriteLine("enter x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter y2");
            double y2 = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            

            return length;
        }
    }
}

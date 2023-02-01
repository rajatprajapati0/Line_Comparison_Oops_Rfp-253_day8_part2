using System;
using System.Buffers.Text;

namespace Line_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Line\r\nComparison Computation **** ");
            Logic obj = new Logic();
            obj.check();
        }
       
    }



    class Logic
    {
      public void check()
        {
            double lenght1 = 0;
            double lenght2 = 0;

            for (int i = 1; i <= 2; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("####### enter valuse for length of first line ######## ");
                    double length = read();
                    Console.WriteLine("Length of line**** " + length);
                    lenght1 = length;
                }
                else
                {
                    Console.WriteLine("####### enter valuse for length of second line ######## ");
                    double length = read();
                    Console.WriteLine("Length of line**** " + length);
                    lenght2 = length;

                }
            }
            int l = lenght1.CompareTo(lenght2);

            if (l==0)
            {
                Console.WriteLine("length of both lines are equle");

            }

            else if (l > 0)
            {
                Console.WriteLine("first line is greater than second line");

            }
            else
            {
                Console.WriteLine("second line is greater than first line");

            }


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
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            return length;
        }

    }
}


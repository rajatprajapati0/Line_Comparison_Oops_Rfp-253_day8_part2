using System;
using System.Buffers.Text;

namespace Line_Comparison
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Welcome to Line\r\nComparison Computation **** ");

            check();


        }


        static void check()
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
                lenght1= length;
                }
                else
                {
                    Console.WriteLine("####### enter valuse for length of second line ######## ");
                    double length= read();
                    Console.WriteLine("Length of line**** " + length);
                    lenght2= length;

                }
              }
            if (lenght1.Equals(lenght2))
            {
                Console.WriteLine("length of both lines are equle");
            
            }
            
            else
            {
                Console.WriteLine("length of both lines are not equle");
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


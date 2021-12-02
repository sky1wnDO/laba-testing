using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string writePath = @"C:\SomeDir\hta.txt";
            double x;
            double b;
            double c;
            int n;
            double x1;
            double  x2;
            List<double> arr = new List<double>() ;
            Console.WriteLine("x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c:");
            c = Convert.ToInt32(Console.ReadLine());

            
            if (b == 100 || c == 2 || c == 13 || (c >= 2 && c <= 13))
            {
                Console.WriteLine("Неверные входные параметры");
            }
            else
            {
                CalculateFunc(x1, x2, n, b, c, arr);
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }

            }


        }
        static public double CalculateFunc(double x1, double x2, int n, double b, double c, List<double> arr)
        {
            if (n == 1 || n < 1 || b == 100  || c == 2 || c == 13 || (c >= 2 && c <= 13)) throw new Exception();
            double dx = (x2 - x1) / (n - 1);
            
           
            for (int i = 0; i < n; i++)
            {
                double x = x1 + dx * i;
                arr.Add(func(x, b, c));

            }
            return 0;
           


        }

        static double func(double x, double b, double c)
        {
            if ( b == 100 || c == 2 || c == 13 || (c >= 2 && c <= 13)) throw new Exception();
            return ((1 / (b - 100)) * Math.Cos((5 * x) / (Math.Sqrt((Math.Pow(c, 2)) - 15 * c + 25))));
        }


        /*  static double func2(double x1, double x2, int n)
          {
              
             List<double> x = new List<double>();
              
              double deltax = (x2 - x1) / (n - 1);
              int i = 0;
              for ( i=0; i < n; i++) {
                  x[i] = x1 + deltax*i;

                  
              }

              return x[i];

          }
       */
   
   

    }
}
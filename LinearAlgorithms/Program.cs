using System;

namespace LinearAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
          var result = Calculate(3.4, 0.74, 19.43);
          Console.WriteLine(result); 
        }

        private static double Calculate (double x, double y, double z)
        {
          double a = Math.Tan(x + y) * Math.Tan(x + y);
          double b = Math.Exp(y - z);
          double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
          double result = a - b * c;
         
          return result;
        }
    }
}

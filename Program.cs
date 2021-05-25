using System;

namespace RandomPi
{
    class Program
    {
        static void Main()
        {
            Random rd = new Random();
            int acertos = 0;
            int n = 5000000;

                for (int i = 0; i < n; i++)
                {
                    double x = rd.NextDouble();
                    double y = rd.NextDouble();

                    if (x * x + y * y < 1)
                    {
                        acertos++;
                    }
                }

            double result = (4.0 * acertos / n);
            Console.WriteLine(result);
            
        }
    }
}

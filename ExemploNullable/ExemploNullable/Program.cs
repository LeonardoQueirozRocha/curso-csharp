using System;

namespace ExemploNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; ERRADO
            // Nullable<double> x = null; CERTO
            //double? x = null; // OUTRA FORMA DE UTILIZAR VALOR NULL EM TIPO STRUCT
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("X is null");
            //}

            //if (y.HasValue)
            //{
            //    Console.WriteLine(y.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Y is null");
            //}

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5; // Se o x for null, a recebe o valor 5
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploModificadorDeParametro
{
    class Calculator
    {
        //public static void Triple(ref int x)
        //{
        //    x = x * 3;
        //}

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

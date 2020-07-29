using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double PorcentagemIof = 6.0;

        public static double ValorPago(double cotacaoDolar, double quantidade)
        {
            double valorIOF = (cotacaoDolar * quantidade * PorcentagemIof) / 100;
            return (cotacaoDolar * quantidade) + valorIOF;
        }
    }
}

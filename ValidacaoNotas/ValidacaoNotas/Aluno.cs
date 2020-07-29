using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ValidacaoNotas
{
    class Aluno
    {
        public string Nome;
        public double PrimeiraNota, SegundaNota, TerceiraNota;

        public double NotaFinal() 
        {
            return (PrimeiraNota + SegundaNota + TerceiraNota);
        }

        public bool AprovadoReprovado() 
        {
            if (NotaFinal() >= 60) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PontosFaltantes() 
        {
            return 60 - NotaFinal();
        }
    }
}

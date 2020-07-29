using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AberturaDeConta
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Deposito(saldo);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "\nConta: " + Numero + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

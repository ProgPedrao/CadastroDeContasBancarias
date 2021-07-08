using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    class Conta
    {
        private const double taxa = 5.00;


        public int NumConta { get;  }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string nome)
        {
            NumConta = conta;
            Nome = nome;
            this.Saldo = 0;
        }

        public Conta(int conta, string nome, double saldo) : this(conta, nome)
        {
            this.Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo -= (valor + taxa);
            }
        }

        public override string ToString()
        {
            return 
                $"--- Dados da conta ---\n" +
                $"Numero da conta - {this.NumConta} \n" +
                $"Nome - {this.Nome} \n" +
                $"Saldo - {this.Saldo.ToString("f2", CultureInfo.InvariantCulture)} \n";
        }
    }
}

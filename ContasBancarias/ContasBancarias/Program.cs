using System;
using System.Globalization;

namespace ContasBancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            int numConta;
            string nome;
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            numConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            nome = Console.ReadLine();

            Console.Write("Deseja realizar um depósito inicial? [s/n] - ");
            
            if (Console.ReadLine().ToLower().StartsWith('s'))
            {
                Console.Write("Entre com o valor do depósito: ");
                saldo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numConta, nome, saldo);
            }
            else
            {
                conta = new Conta(numConta, nome);
            }

            Console.WriteLine(conta.ToString());

            Console.Write("Entre com o valor para o depósito: ");
            conta.Deposito(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(conta.ToString());

            Console.Write("Entre com um valor para saque (R$5,00 de cobrança): ");
            conta.Sacar(Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(conta.ToString());
        }
    }
}

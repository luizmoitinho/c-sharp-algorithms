using System;

namespace _00_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Luiz Carlos Costa Moitinho";
            conta.numeroAgencia = 113;
            conta.saldo = 2500.00f;
            conta.numero = "1000-20xxx";

            Console.WriteLine("Conta criada: {0}",conta.titular);
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();


            conta.Saldo = -275;
            cliente.Nome = "João";
            cliente.CPF = "123.456.789-00";
            cliente.Profissao = "Desenvolvedor C#";


            Console.WriteLine(conta.Saldo);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.CPF);
            Console.WriteLine(cliente.Profissao);


            Console.ReadLine();
        }
    }
}

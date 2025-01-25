using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cliente gabriela = new Cliente();

            // gabriela.nome = "Gabriela";
            // gabriela.cpf = "000.111.222-33";
            // gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = new Cliente();
            // conta.titular.nome = "Gabriela";
            // conta.titular.cpf = "000.111.222-33";
            // conta.titular.profissao = "Desenvolvedora C#";

            conta.agencia = 567;
            conta.numero = 567890;
            conta.saldo = 500;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é NULL");
            }

            //conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(conta.titular);
            // Console.WriteLine(conta.titular.nome);
            // Console.WriteLine(conta.titular.cpf);
            // Console.WriteLine(conta.titular.profissao);

            // Console.WriteLine(gabriela.nome);
            // Console.WriteLine(gabriela.cpf);


            Console.ReadKey();
        }
    }
}

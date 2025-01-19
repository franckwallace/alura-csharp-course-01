using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando (ou criando um objeto) a partir da classe ContaCorrente

            ContaCorrente contaDaGabriela = new ContaCorrente();

            //acessando os parâmetros do objeto e atribuindo valores
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863123;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Número: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);



            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando (ou criando um objeto) a partir da classe ContaCorrente
            ContaCorrente contaDoBruno = new ContaCorrente();

            //acessando os parâmetros do objeto e atribuindo valores
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque + "\n");


            //método/função Depositar
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo + "\n");


            //criando mais uma conta corrente
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo + "\n");

            //manipulando a "contaDoBruno" utilizando o método "Transferir"
            bool resultadoTransferencia1 = contaDoBruno.Transferir(75, contaDaGabriela);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia1 + "\n");


            //manipulando a "contaDaGabriela" utilizando o método "Transferir"
            bool resultadoTransferencia2 = contaDaGabriela.Transferir(1200, contaDoBruno);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia2);



            Console.ReadLine();
        }
    }
}

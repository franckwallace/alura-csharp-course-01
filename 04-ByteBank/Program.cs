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

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);



            Console.ReadLine();
        }
    }
}

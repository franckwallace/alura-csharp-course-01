
//criando uma classe pública chamada ContaCorrente

//using _05_ByteBank;

namespace _05_ByteBank
{


public class ContaCorrente
{
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;


    //criando a função (ou método) Sacar
    // bool representa um tipo que TEM retorno (true ou false)
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        //o "else" foi retirado dessa lógica para simplificação do código
        //else
        //{
        this.saldo -= valor;
        return true;
        //}
    }

    //criando o método (ou função) Depositar
    // void representa um tipo que NÃO tem retorno

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    //Criando o método Transferir
    //Representando no método vários argumentos do tipo ContaCorrente

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        //chamando o método Depositar já criado acima, passando como argumento o "valor" do método Tranferir, atuando no objeto "contaDestino"

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }


}
}
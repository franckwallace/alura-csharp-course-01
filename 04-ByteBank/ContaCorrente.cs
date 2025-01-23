

//criando uma classe pública chamada ContaCorrente
public class ContaCorrente
{
    public string titular;
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
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    //criando o método (ou função) Depositar
    // void representa um tipo que NÃO tem retorno

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }



}
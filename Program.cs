namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício Conta Bancaria - ETECMCM");
        Conta conta = new Conta();
        conta.nomeCliente = "Anderson vanin";
        conta.limite = 500;

        conta.depositar(200);

        conta.sacar(50);

        double saldo = conta.ConsultaSaldo();

        //Agora para visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);

    
    }
     
 }       
       

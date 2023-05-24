namespace exe_2;
class Program
{
    static void Main(string[] args)
    {
       ContratoPessoaFisica n1 = new ContratoPessoaFisica();
       ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

       n1.Nome = "José";
       n1.Email = "josehenriquegamer663@gmail.com";
       n1.Telefone = "(11)955990853";
       n1.Cpf = "155.333.153-13";
       n1 .Idade = 16;

       n2.Nome = "José";
       n2.Email = "jose.silva2093@etec.sp.gov.br";
       n2.Telefone = "(11)955990853";
       n2.Cnpj = "52990256776";
       n2.IE = "6372376689";
       n2.NomeEmpresa = "Grife do Zé";


         Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());


    }
}

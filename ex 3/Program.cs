namespace ex 3;
class Program :Contrato
{
    static void Main(string[] args)
    {
         ContratoPessoasFisica n1 = new ContratoPessoasFisica();
         ContratoPessoasJuridica n2 = new ContratoPessoasJuridica();

        n1.Email = "josehenriquegamer663@gmail.com";
        n1.Nome = "jose";
        n1.Telefone = "(11) 6379-3652";
        n1.cpf = "539.256.268-08";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "Nicole.pontes2@etec.sp.gov.br";
        n2.Nome = "Nicole";
        n2.Telefone = "(11) 92723-9278";
        n2.cnpj = "666566";
        n2.ie = "2626362353";
        n2.NomeEmpresa = "Grfe do ze";
        n2.Prazo = 10;

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}

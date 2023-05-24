namespace ex 3;
class ContratoPessoasFisica:Contrato
dot
{
    public string? cpf {get;set;}
    public int? Idade {get;set;}

    public override string MostraDados(){
        return base.MostraDados() + " - CPF:" + this.cpf + " - Idade:" + this.Idade;
    }

    public override double calcularPrestacao(){
        if (Idade <= 30)
        {
            return ((base.calcularPrestacao()/Prazo)+1);
        } else if (Idade <= 40)
        {
            return ((base.calcularPrestacao()/Prazo)+2);
        } else if (Idade <= 50)
        {
            return ((base.calcularPrestacao()/Prazo)+3);
        } else 
        {
            return ((base.calcularPrestacao()/Prazo)+4);
        } 
    }
}
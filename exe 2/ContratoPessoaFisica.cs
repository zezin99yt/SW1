namespace exe_2;
class ContratoPessoaFisica : Contrato
{
    public string? Cpf;
    public int Idade;

       public override string MostraDados(){
        return base.MostraDados() + " - Cpf:" + this.Cpf + " - Idade:" + this.Idade;

}
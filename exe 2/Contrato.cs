namespace exe_2;
class Contrato
{
    public string? Nome{get;set;}
    public string? Email;
    public string? Telefone;
    
     public virtual string MostraDados(){
         return "Nome: " + this.Nome + " - Email: " + this.Email + " - Telefone: " + this.Telefone;
    }
}

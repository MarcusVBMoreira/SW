namespace ex_2;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}


    //Declarando o que as "classes filhas" vão herdar da "classe mãe"
    public virtual string MostraDados(){
        string tudo = "Nome: " + this.Nome + "  " + "Email: " + this.Email + "  " + "Telefone: " + this.Telefone + "  ";
        return tudo;
    }

    
}

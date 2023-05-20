namespace ex_3;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}
    public int Valor{get;set;}
    public int Parcelas{get;set;}
    public int Total{get;set;}


    //Declarando o que as "classes filhas" vão herdar da "classe mãe"
    public virtual string MostraDados()
    {
        string tudo = "Nome: " + this.Nome + "  " + "Email: " + this.Email + "  " + "Telefone: " + this.Telefone + "  ";
        return tudo;
    }

    public virtual string CalcularPrestação()
    {
        Total = Valor/Parcelas;
        return "O valor da parcela sem juros é de: R$" + Total + ",00 por mês. ";
    }
    
}

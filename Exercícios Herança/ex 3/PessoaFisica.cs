namespace ex_3;
class PessoaFisica:Contrato
{
    public string? CPF{get;set;}
    public string? Idade{get;set;}
    public int totalpf{get;set;}
    public int idade{get;set;}

    public override string MostraDados()
    {
        return base.MostraDados()+ "CPF: " + this.CPF + "  " + "Idade: " + this.Idade;
    }

    public override string CalcularPrestação()
    {
        if (idade <= 30){
            totalpf = Total + 1;
        }else if(idade <=40){
            totalpf = Total + 2;
        }else if(idade <=50){
            totalpf = Total + 3;
        }else if(idade > 50){
            totalpf = Total + 4;
        }
        
        return base.CalcularPrestação() + "O valor da prestação com juros é de: R$" + totalpf + ",00 por mês";
    }
}

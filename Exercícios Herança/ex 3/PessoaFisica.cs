namespace ex_3;
class PessoaFisica:Contrato
{
    public string? CPF{get;set;}
    public int Idade{get;set;}
    public double totalpf{get;set;}

    public override string MostraDados()
    {
        return base.MostraDados()+ "CPF: " + this.CPF + "  " + "Idade: " + this.Idade;
    }

    public override double CalcularPrestação(int Valor, int Parcelas)
    {
        if (Idade <= 30){
            return base.CalcularPrestação(Valor, Parcelas) + 1;
        }else if(Idade <=40){
            return base.CalcularPrestação(Valor, Parcelas) + 2;
        }else if(Idade <=50){
            return base.CalcularPrestação(Valor, Parcelas) + 3;
        }else{
            return base.CalcularPrestação(Valor, Parcelas) + 4;
        }
        
    }
}

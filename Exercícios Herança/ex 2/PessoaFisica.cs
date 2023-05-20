namespace ex_2;
class PessoaFisica:Contrato
{
    public string? CPF{get;set;}
    public string? Idade{get;set;}

    public override string MostraDados()
    {
        return base.MostraDados()+ "CPF: " + this.CPF + "  " + "Idade: " + this.Idade;
    }
}

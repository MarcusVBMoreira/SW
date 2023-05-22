namespace ex_3;
class PessoaJuridica:Contrato
{
    public string? NomeEmpresa{get;set;}
    public string? CNPJ{get;set;}
    public string? IE{get;set;}


    public override string MostraDados()
    {
        return base.MostraDados() + "Nome da empresa:" + NomeEmpresa + "  " + "CNPJ:" + CNPJ + "  " + "IE:" + IE;
    }

    public override double CalcularPrestação(int Valor, int Parcelas)
    {
        return  base.CalcularPrestação(Valor, Parcelas) + 3;
    }
}

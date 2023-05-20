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

    public override string CalcularPrestação()
    {
        int totalpj = 3 + Total;
        return  base.CalcularPrestação() + "O valor da prestação com juros é de: R$" + totalpj + ",00 por mês";
    }
}

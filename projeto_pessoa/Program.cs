namespace projeto_pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 =  new Pessoa("Marcus",16);
        //p1.AlteraNome("Marcus");
        //p1.AlteraSobreNome("Moreira");
        //p1.AlteraIdade(16);
        p1.MostraDados();
    }
}

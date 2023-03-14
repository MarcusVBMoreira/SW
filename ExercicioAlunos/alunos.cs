namespace ExercicioAlunos;
class Alunos
{
    public string nome="";
    public double nota1, nota2;

    //Média -> retorna um double (por exemplo um número como 8,8)
    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }

    //situação -> retorna uma string ("Aprovado" ou "Reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;
    }


    //Mensagem -> Não retorna nada. Só mostra na tela detalhes (nome, media e situação)
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadosSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadosSituacao+" com média: "+mediaCalculada);
    }


}
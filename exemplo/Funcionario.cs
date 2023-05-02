namespace exemplo;
class Funcionario
{
    public string? Nome {get;set;}
    public int Idade {get;set;}

    public virtual double Lucro(){
        return 12000;
    }
}
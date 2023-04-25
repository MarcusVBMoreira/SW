namespace Juros;
class Conta{
  //variaveis
     public int Numero {get;private set;}
    private decimal Saldo {get;set;}
    public decimal Limite {get;private set;}
   

    public void AlterarNumero(int n){
        this.Numero = n;
    }
    public decimal ConsultaSaldo(){
        return this.Saldo;
    }
    public void Deposito(decimal v){
        this.Saldo += v;
    }
    public void Sacar(decimal v){
        if(v>this.Saldo){
            Console.WriteLine("Você não possui esse dinheiro.");
        }else{
            this.Saldo -= v;
        }
    } //sald0=limite
    public void DefinirLimite(decimal v){
        this.Limite = v;
    }
    public void CalculaJuros(decimal emprestimo,int prazo,decimal taxa){
        //calculos
        decimal prestacao = emprestimo/prazo;
        decimal juros = (taxa/100)*emprestimo;
        decimal prestacaoeJjuros = juros+prestacao;
        decimal total = prestacaoeJjuros*prazo;

        Console.WriteLine("Empréstimo:"+emprestimo); 
        Console.WriteLine("Prazo :  meses"+prazo);
        Console.WriteLine("Taxa "+taxa);
        Console.WriteLine("Juros: "+juros);
        Console.WriteLine("Prestação: "+prestacao);
        Console.WriteLine("Valor da prestação com juros:"+prestacaoeJjuros);
        Console.WriteLine("Total a pagar: "+total);
    }
}
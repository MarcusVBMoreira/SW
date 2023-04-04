namespace banco;
class Conta 
{
    public int Numero {get;set;}
    private double Saldo { get; set;}
    public double Limite {get;set;}

    public void Depositar(double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if(valor > this.Saldo+this.Limite){
            Console.WriteLine("Você não pode realizar este saque!! Saldo Insuficiente!");
        }else{
            this.Saldo -= valor;
        }
        this.Saldo -= valor;
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }
    public void AjustaLimite(double valor){
        this.Limite = valor; 
    }
}
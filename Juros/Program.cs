namespace Juros;
class Program
{
    static void Main(string[] args)
    {
        Conta contaum = new Conta();
        contaum.Deposito(2000);
        contaum.DefinirLimite(500);
        contaum.AlterarNumero(12345);
        contaum.Sacar(1500);
        Console.WriteLine("Valor é: "+contaum.ConsultaSaldo());
        contaum.CalculaJuros(1000,12,6);
    }
}
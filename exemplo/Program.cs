namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        FuncionarioN1 n1 = new FuncionarioN1();
        FuncionarioN2 n2 = new FuncionarioN2();
        FuncionarioN3 n3 = new FuncionarioN3();

        n1.Nome = "Marcus";
        n1.Idade = 16;
        n2.Nome = "Anderson";
        n2.Idade = 48;
        n3.Nome = "Fulano";
        n3.Idade = 18;

        Console.WriteLine("Nome: " + n1.Nome + "-- Idade: " + n1.Idade + "-- Lucro: " + n1.Lucro());
        Console.WriteLine("Nome: " + n2.Nome + "-- Idade: " + n2.Idade + "-- Lucro: " + n2.Lucro());
        Console.WriteLine("Nome: " + n3.Nome + "-- Idade: " + n3.Idade + "-- Lucro: " + n3.Lucro());
    }
}

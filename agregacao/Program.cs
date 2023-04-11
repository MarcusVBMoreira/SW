namespace agregacao;
class Program
{
   static void Main(string[] args)
   {
        Console.WriteLine("Trabalhando com Agregação");

        //instanciando os objetos de cada calasse
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();


        //adicionando um nome para um cliente
        cli.Nome = "Marcus Moreira";

        //adicionando número e validade do cartão de Crédito
        cdc.Numero = "123456789";
        cdc.DataValidade = "12/2025";

        //Associando  o cliente ao atributo de agregação em Cartão de Crétido
        cdc.Cliente = cli;

        //visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente agregado é: " + cdc.Cliente.Nome);
   }

}

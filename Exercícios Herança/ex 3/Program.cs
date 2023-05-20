namespace ex_3;
class Program
{
    static void Main(string[] args)
    {
        //Intânciando a classe
        Contrato c = new Contrato();
        PessoaFisica pf = new PessoaFisica();
        PessoaJuridica pj = new PessoaJuridica();


        //Fazendo o usuário escolher se é CPF ou CNPJ
        string? Escolha = string.Empty;

        while(Escolha != "CPF" && Escolha != "CNPJ")
        {
            Console.WriteLine("Você utiliza CPF ou CNPJ?");
            Escolha = Console.ReadLine();

            switch (Escolha)
            {
                case "CPF":
                    Console.Clear();
                    Console.WriteLine("Contrato de Pesso Física");
                    Console.WriteLine("");
                    Console.WriteLine("Escreva o seu Nome: ");
                    pf.Nome = Console.ReadLine();
                    Console.WriteLine("Escreva o seu Email: ");
                    pf.Email = Console.ReadLine();
                    Console.WriteLine("Escreva o seu Telefone: ");
                    pf.Telefone = Console.ReadLine();
                    Console.WriteLine("Escreva o seu CPF: ");
                    pf.CPF = Console.ReadLine();
                    Console.WriteLine("Escreva a sua Idade: ");
                    pf.Idade = Console.ReadLine();



                    Console.WriteLine("Digite o valor total que deja parcelar: ");
                    pf.Valor = 1000;
                    Console.WriteLine("Digite a quantidade de vazes que deseja parcelar");
                    pf.Parcelas = 10;
                    Console.WriteLine("Qual é a sua idade");
                    pf.idade = 51;
                
                    
                
                    Console.Clear();
                    Console.WriteLine(pf.MostraDados());
                    Console.WriteLine(pf.CalcularPrestação());


                    break;

                case "CNPJ":
                    Console.Clear();
                    Console.WriteLine("Contrato Pessoa Jurídica");
                    Console.WriteLine("");
                    Console.WriteLine("Escrava o seu Nome: ");
                    pj.Nome = Console.ReadLine();
                    Console.WriteLine("Escreva o seu Email: ");
                    pj.Email = Console.ReadLine();
                    Console.WriteLine("Escreva o seu Telefone: ");
                    pj.Telefone = Console.ReadLine();
                    Console.WriteLine("Escreva o nome da Empresa: ");
                    pj.NomeEmpresa = Console.ReadLine();
                    Console.WriteLine("Escreva o CNPJ da empresa: ");
                    pj.CNPJ = Console.ReadLine();
                    Console.WriteLine("Escreva o IE da empresa:");
                    pj.IE = Console.ReadLine();


                    Console.WriteLine("Digite o valor total que deja parcelar: ");
                    pj.Valor = 1000;
                    Console.WriteLine("Digite a quantidade de vazes que deseja parcelar");
                    pj.Parcelas = 10;


                    Console.Clear();
                    Console.WriteLine(pj.MostraDados());
                    Console.WriteLine(pj.CalcularPrestação());

                    break;
            }
        }
    }
}

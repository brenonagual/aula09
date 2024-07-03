using senaiaulaback.Classes;
string? opcao;

do
{
    Console.Clear();

    Console.WriteLine(@"
        1 - Cadastrar PJ
        2 - Listar PJ
        0 - Sair
    ");

    opcao = Console.ReadLine();

    PessoaJuridica metodosPj = new PessoaJuridica();

    if (opcao == "1") {
        PessoaJuridica pj = new PessoaJuridica();

        Console.WriteLine("Digite o nome da PJ: ");
        pj.Nome = Console.ReadLine();

        Console.WriteLine("Informe o rendimento da PJ: ");
        pj.Rendimento = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o CNPJ da PJ: ");
        pj.Cnpj = Console.ReadLine();

        metodosPj.Inserir(pj);


    } else if (opcao == "2") {

    } else if (opcao == "0") {
        Console.WriteLine("Obrigado por utilizar nosso sistema! :)");
    } else {
        Console.WriteLine("Opção inválida, tente novamente.");
    }

} while (opcao != "0");
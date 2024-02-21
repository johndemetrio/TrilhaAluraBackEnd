using Desafio_2.Modelos;

Excecoes excecoes = new Excecoes();
Servicos Servico = new Servicos(excecoes);
void VoltarMenu()
{
    System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    System.Console.WriteLine("");
    Menu();
}
void Menu()
{
    Console.Clear();
    System.Console.WriteLine("1 -> Lista de Temporadas");
    System.Console.WriteLine("2 -> Calendário de corridas");
    System.Console.WriteLine("3 -> Pilotos");
    System.Console.WriteLine("4 -> Equipes");
    System.Console.WriteLine("5 -> Sair da aplicação");
    System.Console.WriteLine("");
    System.Console.Write("Digite a opção desejada: ");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            Servico.ExibirTemporadas().Wait();
            VoltarMenu();
        break;

        case "2":
            Servico.ExibirCalendario().Wait();
            VoltarMenu();
        break;

        case "3":
            Servico.ExibirPilotos().Wait();
            VoltarMenu();
        break;

        case "4":
            Servico.ExibirConstrutores().Wait();
            VoltarMenu();
        break;

        case "5":
            Console.Clear();
            System.Console.WriteLine("Pressione qualquer tecla para sair da aplicação");
            Console.ReadKey();
        break;

        default:
            System.Console.WriteLine("Opção Inválida. Digite novamente");
            VoltarMenu();
        break;
    }
}
Menu();
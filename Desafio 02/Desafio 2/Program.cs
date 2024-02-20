using System.Text.Json;
using Desafio_2.Modelos;

Filtros Filtro = new Filtros();
void VoltarMenu()
{
    System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Menu();
}
void Menu()
{
    ///Console.Clear();
    System.Console.WriteLine("1 -> Lista de Temporadas");
    System.Console.WriteLine("2 -> Calendário de corridas");
    System.Console.WriteLine("3 -> Temporada atual");
    System.Console.WriteLine("4 -> Pilotos");
    System.Console.WriteLine("5 -> Equipes");
    System.Console.WriteLine("6 -> Sair da aplicação");
    System.Console.Write("Digite a opção desejada: ");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            Filtro.ExibirTemporadas().Wait();
            VoltarMenu();
            //Menu();
            break;
        case "2":
            Filtro.ExibirCalendario().Wait();
            VoltarMenu();
            break;
        case "3":
            Filtro.ExibirCalendarioAtual().Wait();
            VoltarMenu();
            break;
        case "4":
            Filtro.ExibirPilotos().Wait();
            VoltarMenu();
            break;
        case "5":
            
            VoltarMenu();
            break;
        case "6":
            Console.Clear();
            System.Console.WriteLine("Pressione qualquer tecla para sair da aplicação");
            Console.ReadKey();
            break;
        default:
            System.Console.WriteLine("Opçao incorreta. Digite novamente");
            VoltarMenu();
            break;
    }
}
Menu();
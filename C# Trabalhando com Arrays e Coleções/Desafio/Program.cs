Dictionary<string, List<string>> timesRegistrados = new Dictionary<string, List<string>>();
string[] posicoes = ["Goleiro","Lateral esquerdo", "Zagueiro", "Zagueiro", "Lateral Direito", "Meia Direita", "Meia Central", "Meia Esquerda", "Ponta Direita", "Centroavante", "Ponta Esquerda"];

void Menu()
{
    Console.WriteLine("======================");
    Console.WriteLine("=== Monte seu time ===");
    Console.WriteLine("======================");
    Console.WriteLine("\n1 - Criar time");
    Console.WriteLine("2 - Exibir escalação do time");
    Console.WriteLine("3 - Exibir times os times criados");
    Console.WriteLine("4 - Sair da aplicação");
    System.Console.WriteLine();
    System.Console.Write("Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1: CriarTime();
            break;
        case 2: ExibirTime();
            break;
        case 3: MostrarTimesCriados();
            break;
        default: Console.WriteLine("Opção Inválida. Tente novamente");
            Menu();
    }
}

void CriarTime(){
    Console.Clear();
    Console.WriteLine("Digite o nome do time que deseja registrar: ");
    string nomeDoTime = Console.ReadLine()!;
    timesRegistrados.Add(nomeDoTime, new List<string>());
    Thread.Sleep(2000);
    Console.Clear();
    System.Console.WriteLine("Time registrado com sucesso.");
    System.Console.WriteLine();
    foreach (string posicao in posicoes)
    {
        System.Console.WriteLine($"Escolha o jogador para a posição de: {posicao}");
        string jogador = Console.ReadLine()!;
        timesRegistrados[nomeDoTime].Add(jogador);
        System.Console.WriteLine("Jogador adicionado com sucesso!");
        Thread.Sleep(500);
        Console.Clear();
    }
    System.Console.WriteLine("Time cadastrado com sucesso!");
    Menu();
}

void ExibirTime(){
    Console.Clear();
    System.Console.WriteLine("Digite o nome do time para exibir: ");
    string nomeDoTime = Console.ReadLine()!;
    int i = 0;
    if(timesRegistrados.ContainsKey(nomeDoTime)){
        foreach (string jogador in timesRegistrados[nomeDoTime])
        {
            System.Console.WriteLine($"{posicoes[i]}: {jogador}", i++);
        }
    }
    Menu();
}
Menu();
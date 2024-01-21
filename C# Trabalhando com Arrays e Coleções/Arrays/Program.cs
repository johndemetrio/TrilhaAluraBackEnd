Console.WriteLine("Boas vindas ao ByteBank");

//TestaArray();
//TestaBuscarPalavra();

void TestaArray(){
    int [] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = {idade}");
        acumulador+= idade;
    }
    double media = idades.Average();
    Console.WriteLine($"A média de idades é de: {media}");

}

void TestaBuscarPalavra(){

    string [] arrayDePalavras = new string[5];
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite {i + 1}º Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();

    }
    
    Console.WriteLine("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();
    
    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }else
        {
        Console.WriteLine($"Palavra não encontrada");
        }
    }  
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9,0);
amostra.SetValue(1.8,1);
amostra.SetValue(1.8,2);
amostra.SetValue(7.1,3);
amostra.SetValue(6.9,4);

// TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da media está vazio ou nulo");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2!=0) ?numerosOrdenados[meio]: (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    System.Console.WriteLine($"O valor da mediana é {mediana}");
}

void TestaLista{
    
}
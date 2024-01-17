void funcaoOperacoesBasicas(float a, float b){
    float soma = a + b;
    float subtracao = a - b;
    float divisao = a / b;
    float multiplicacao = a * b;
    Console.WriteLine("A soma do número A:{0} e do B:{1} é de {2}", a, b, soma);
    Console.WriteLine("A subtração do número A:{0} e do B:{1} é de {2}", a, b, subtracao);
    Console.WriteLine("A divisão do número A:{0} e do B:{1} é de {2}", a, b, divisao);
    Console.WriteLine("A multiplicação do número A:{0} e do B:{1} é de {2}", a, b, multiplicacao);
}
funcaoOperacoesBasicas(10, 2);
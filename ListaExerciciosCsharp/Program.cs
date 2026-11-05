// Exercício 1 - Calculando uma compra 
/*
Console.Write("Nome do produto: ");
String? nomeProduto = Console.ReadLine();

Console.Write("Quantidade comprada: ");
int quantidadeProduto;
quantidadeProduto = int.Parse(Console.ReadLine()!);

Console.Write("Preço: ");
decimal precoProduto;
precoProduto = decimal.Parse(Console.ReadLine()!);

Console.WriteLine();
decimal precoTotal = precoProduto * quantidadeProduto;

Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Quantidade: {quantidadeProduto}");
Console.WriteLine($"Preço do Produto: {precoProduto:C}");
Console.WriteLine($"Gasto Total: {precoTotal:C}");
*/

// Exercício 2 - Classificação de notas
/*
Console.Write("Nome do Aluno: ");
string? nomeAluno = Console.ReadLine();

Console.Write("Nota do Aluno: ");
int notaALuno;
notaALuno = int.Parse(Console.ReadLine()!);

if (notaALuno >= 11 || notaALuno < 0)
    Console.WriteLine("Valor inválido");
else if (notaALuno >= 7)
    Console.WriteLine("Aluno aprovado");
else if (notaALuno >= 5)
    Console.WriteLine("Aluno deverá realizar a recuperação");
else if (notaALuno <= 5)
    Console.WriteLine("Aluno Reprovado");
*/

// Exercício 3 - Adivinhe o número
/*
int numeroSecreto = 25;
int tentativa;
int contador = 0;

Console.WriteLine("Jogo do Número Secreto");

Console.Write("Digite um número: ");
tentativa = int.Parse(Console.ReadLine());

while (tentativa != numeroSecreto)
{
    contador++;

    if (tentativa < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior!");
    }
    else
    {
        Console.WriteLine("O número secreto é menor!");
    }

    Console.WriteLine("\nTente novamente: ");
    tentativa = int.Parse(Console.ReadLine()!);
}

contador++;

Console.WriteLine("\nParabéns! Você acertou!");
Console.WriteLine("Quantidade de tentativas: " + contador);
*/

// Exercício 4 - Calculadora com métodos
// SOMA
/*
Console.Write("Digite um número: ");
int a;
a = int.Parse(Console.ReadLine()!);
Console.Write("Digite outro número: ");
int b;
b = int.Parse(Console.ReadLine()!);

static int Somar(int a, int b)
{   
    return a + b;
}

int resultadoSoma = Somar(a, b);

Console.WriteLine(resultadoSoma);
*/

// MULTIPLICAÇÃO
/*
Console.Write("Digite um número: ");
int a;
a = int.Parse(Console.ReadLine()!);
Console.Write("Digite outro número: ");
int b;
b = int.Parse(Console.ReadLine()!);

static int Multiplicar(int a, int b)
{   
    return a * b;
}

int resultadoMultiplicacao = Multiplicar(a, b);

Console.WriteLine(resultadoMultiplicacao);
*/

// Exercício 5 - Cadastro de notas em um array

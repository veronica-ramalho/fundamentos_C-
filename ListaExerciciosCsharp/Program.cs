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
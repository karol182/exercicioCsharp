// ENTRADA DE DADOS

Console.WriteLine("Digite a primeira nota:");

double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");

double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");

double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");

double nota4 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quinta nota:");

double nota5 = double.Parse(Console.ReadLine());

//PROCESSAMENTO DE DADOS

double media = (nota1 + nota2 + nota3 + nota4 + nota5)/5;

//SAÍDA DE DADOS

Console.Write($"A média das 5 notas é de: {Math.Round(media)}"); // conversão de dados (Math.Round)
Console.Write($"A média das 5 notas é de: {media:F2}"); // conversão de dados (F format)






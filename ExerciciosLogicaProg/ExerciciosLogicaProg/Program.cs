//// Exercicios Obrigatórios

////1 - Tartarugas

int metrosPrimeira = 30;
int diasPrimeira = 16;
int metrosSegunda = 20;

int distancia = metrosPrimeira * diasPrimeira;
int diasSegunda = distancia / metrosSegunda;
int espera = diasSegunda - diasPrimeira;

Console.WriteLine("  EXERCÍCIO 1 - TARTARUGA  ");
Console.WriteLine($"A segunda tartaruga chega em {diasSegunda} dias.");
Console.WriteLine($"Dias de espera: {espera}");

////2 - Baralho

int totalCartas = 52;
int cartasColunas = 1 + 2 + 3 + 4 + 5 + 6 + 7;
int monte = totalCartas - cartasColunas;

Console.WriteLine("  EXERCÍCIO 2 - BARALHO  ");
Console.WriteLine($"Cartas nas colunas: {cartasColunas}");
Console.WriteLine($"Cartas no monte: {monte}");

////3 - Pizzaria

int sabores = 3;
int bordas = 2;
int tamanhos = 2;

int combinacoes = sabores * bordas * tamanhos;

Console.WriteLine("  EXERCÍCIO 3 - PIZZARIA  ");
Console.WriteLine($"{sabores} * {bordas} * {tamanhos} = {combinacoes}");

////4 - Sequências

int seq1 = 7 + 2;
int seq2 = 64 * 2;
int seq3 = 7 * 7;
int seq4 = 10 * 10;
int seq5 = 5 + 8;
int seq6 = 200;

Console.WriteLine("  EXERCÍCIO 4 - SEQUÊNCIAS  ");
Console.WriteLine($"I: {seq1}");
Console.WriteLine($"II: {seq2}");
Console.WriteLine($"III: {seq3}");
Console.WriteLine($"IV: {seq4}");
Console.WriteLine($"V: {seq5}");
Console.WriteLine($"VI: {seq6}");

////NÍVEL FÁCIL


//// Soma simples

Console.WriteLine("Digite o primeiro número:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;

Console.WriteLine($"{n1} + {n2} = {soma}");


////Par ou ímpar

Console.WriteLine("Digite um número:");
int numeros = int.Parse(Console.ReadLine());

if (numeros % 2 == 0)

    Console.WriteLine($"{numeros} é par");

else

Console.WriteLine($"{numeros} é ímpar");



//// Maior número

Console.WriteLine("Digite o primeiro número:");
int n_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int n_2 = int.Parse(Console.ReadLine());

if (n_1 > n_2)

    Console.WriteLine($"O maior é {n_1}");

else if (n_2 > n_1)

    Console.WriteLine($"O maior é {n_2}");

else

    Console.WriteLine("Os números são iguais");



//// Idade mínima

Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)

    Console.WriteLine("Maior de idade");

else

    Console.WriteLine("Menor de idade");



//// NÍVEL MÉDIO 

//// Intervalo numérico

Console.WriteLine("Digite um número:");
int num = int.Parse(Console.ReadLine());

if (num >= 50 && num <= 100)

    Console.WriteLine($"{num} está entre 50 e 100");

else

    Console.WriteLine($"{num} não está entre 50 e 100");



//// Desconto em produto

Console.WriteLine("Digite o valor do produto:");
double valor = double.Parse(Console.ReadLine());

if (valor > 100)

    valor = valor * 0.9;
Console.WriteLine("Desconto de 10% aplicado");


Console.WriteLine($"Valor final: {valor}");


////  Positivo, negativo ou zero

Console.WriteLine("Digite um número:");
int _numero = int.Parse(Console.ReadLine());

if (_numero > 0)

    Console.WriteLine("Positivo");

else if (_numero < 0)

    Console.WriteLine("Negativo");

else

    Console.WriteLine("Zero");



//// NÍVEL DIFÍCIL 

//// Login simples

Console.WriteLine("Usuário:");
string usuario = Console.ReadLine();

Console.WriteLine("Senha:");
string senha = Console.ReadLine();

if (usuario == "admin" && senha == "1234")

    Console.WriteLine("Login realizado com sucesso");

else

    Console.WriteLine("Usuário ou senha inválidos");



////  Maior de três números

Console.WriteLine("Digite o primeiro número:");
int numeroUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int numeroDois = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
int numeroTres = int.Parse(Console.ReadLine());

int maior = numeroUm;

if (numeroDois > maior)

    maior = numeroDois;


if (numeroTres > maior)

    maior = numeroTres;


Console.WriteLine($"O maior é {maior}");


//// Salário com bônus

Console.WriteLine("   SALÁRIO COM BÔNUS  ");
Console.WriteLine("Digite o salário:");
double salario = double.Parse(Console.ReadLine());

double novoSalario;

if (salario > 2000)

    novoSalario = salario * 1.10;

else

    novoSalario = salario * 1.20;


Console.WriteLine($"Novo salário: {novoSalario}");


//// Ano bissexto 
///
Console.WriteLine("   ANO BISSEXTO   ");
Console.WriteLine("Digite um ano:");
int ano = int.Parse(Console.ReadLine());

if (ano % 4 == 0)

    Console.WriteLine($"{ano} é bissexto");

else

    Console.WriteLine($"{ano} não é bissexto");



// Validação de acesso

Console.WriteLine("Digite a idade:");
int _idade = int.Parse(Console.ReadLine());

Console.WriteLine("Possui convite? (sim/não)");
bool convite = bool.Parse(Console.ReadLine());

if (_idade >= 18 && convite == true)

    Console.WriteLine("Acesso permitido");

else

    Console.WriteLine("Acesso negado");

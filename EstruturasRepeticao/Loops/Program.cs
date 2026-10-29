Console.WriteLine("Estruturas de Repetição!");


//for (variavel; condição; incremento)

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//while
//criar um programa que pergunte a idade do pericles


Console.WriteLine("Informe a idade do Pericles");
int idadePericles = int.Parse(Console.ReadLine()!);

while (idadePericles != 57)
{
    Console.WriteLine("Errou, tente novamente! ");
    // if tenario
    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");
    idadePericles = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Você acertou!");

// do while 

//int idadePericles;
//do
//{
//    Console.WriteLine("Informe a idade do Pericles");
//    idadePericles = int.Parse(Console.ReadLine());

//    if (idadePericles == 57)
//    {
//        Console.WriteLine("Você acertou!");
//        break;
//    }
//    // if tenario
//    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");

//} while (idadePericles != 57);

// foreach

string[] nomes = { "Karol", "Gustavo", "Guilherme", "Bianca", "Dayane" };
    try
    {
        Console.WriteLine(nomes[2]);
        foreach (string nome in nomes)
        {

        }
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("o index está fora do alcance! ");
    }

    // for (int i = 0; i < nomes.Length; i++)
    // Console.WriteLine(nomes[i]);


    int[] numeros = { 2, 4, 6, 8 };
    int soma = 0;

    foreach (int n in numeros)
    {
        soma += n;
    }

    Console.WriteLine("Soma: " + soma);

//crie um programa que vai pedir um numero para o usuário 
// e o programa deve mostrar a tabuada desse número da seguinte maneira:
// 5x1 = 5
// 5x2 = 10
// 5x10 = 50
//faça com que o programa continue perguntando um numero para a tabuada até que o usuario decida sair do programa
//string continuarTabuada;

string continuarTabuada;

do
{
    Console.WriteLine("Digite um número:");
    int numTabuada = int.Parse(Console.ReadLine()!);

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numTabuada}x{i} = {numTabuada * i}");
    }

    Console.WriteLine("Quer ver outra tabuada? (s/n)");
    continuarTabuada = Console.ReadLine()!;
}
while (continuarTabuada == "s");

Console.WriteLine("Programa encerrado");


//1. média com foreach
//Faça um programa que leia 5 números e informe a soma e a média dos números.
double[] numMedia = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o número {i + 1}:");
    numMedia[i] = double.Parse(Console.ReadLine()!);
}

double somaNumeros = 0;

foreach (double valor in numMedia)
{
    somaNumeros += valor;
}

double mediaNumeros = somaNumeros / numMedia.Length;

Console.WriteLine($"Soma: {somaNumeros}");
Console.WriteLine($"Média: {mediaNumeros}");


//2. faça um programa que dado um conjunto de N numeros, determine o menor valor, o maior valor e a soma dos valores.
Console.WriteLine("Quantos números você vai digitar?");
int quantidadeN = int.Parse(Console.ReadLine()!);

if (quantidadeN <= 0)
{
    Console.WriteLine("Quantidade inválida");
}
else
{
    Console.WriteLine("Digite o número 1:");
    int primeiroN = int.Parse(Console.ReadLine()!);

    int menorN = primeiroN;
    int maiorN = primeiroN;
    int somaN = primeiroN;

    for (int i = 2; i <= quantidadeN; i++)
    {
        Console.WriteLine($"Digite o número {i}:");
        int atualN = int.Parse(Console.ReadLine()!);

        if (atualN < menorN)
        {
            menorN = atualN;
        }

        if (atualN > maiorN)
        {
            maiorN = atualN;
        }

        somaN += atualN;
    }

    Console.WriteLine($"Menor: {menorN}");
    Console.WriteLine($"Maior: {maiorN}");
    Console.WriteLine($"Soma: {somaN}");
}

//3. numa eleição existem 3 candidatos, faça um programa que peça o número total de eleitores, peça para cada eleitor votar e ao final mostrar o número de votos de cada candidato
Console.WriteLine("Quantos eleitores vão votar?");
int totalEleitores = int.Parse(Console.ReadLine()!);

int votosCand1 = 0;
int votosCand2 = 0;
int votosCand3 = 0;


for (int i = 1; i <= totalEleitores; i++)
{
    Console.WriteLine($"Eleitor {i}, vote (1, 2 ou 3):");
    int voto = int.Parse(Console.ReadLine()!);

    if (voto == 1)
    {
        votosCand1++;
    }
    else if (voto == 2)
    {
        votosCand2++;
    }
    else if (voto == 3)
    {
        votosCand3++;
    }
}

Console.WriteLine($"Candidato 1: {votosCand1} votos");
Console.WriteLine($"Candidato 2: {votosCand2} votos");
Console.WriteLine($"Candidato 3: {votosCand3} votos");

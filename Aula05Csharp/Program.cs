// Exercicio 1 
Console.WriteLine("Digite a temperatura em °C:");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura < 15)
{
    Console.WriteLine("Está frio");
}

else if (temperatura > 30)
{
    Console.WriteLine("Está quente");
}
else
{
    Console.WriteLine("Está agradável");
}

// Exercicio 2 

Console.WriteLine("Digite um número:");
int numeroValido = int.Parse(Console.ReadLine());

if (numeroValido > 100)
{
    Console.WriteLine($"{numeroValido} é maior que 100");
}
else
{
    Console.WriteLine($"{numeroValido} não é maior que 100");
}

// Exercicio 3 

Console.WriteLine("Digite a senha:");
string senha = Console.ReadLine();

if (senha == "123")
{
    Console.WriteLine("Senha correta");
}
else
{
    Console.WriteLine("Senha incorreta");
}

// Exercicio 4

Console.WriteLine("Digite um número:");
int numeroNegativo = int.Parse(Console.ReadLine());

if (numeroNegativo < 0)
{
    Console.WriteLine("Número inválido");
}

// Exercicio 5 
Console.WriteLine("Digite a idade:");
int idadeCadastro = int.Parse(Console.ReadLine());
string resultado = idadeCadastro >= 16 ? "Cadastro permitido" : "Cadastro não permitido";

Console.WriteLine(resultado);


// Exercicio 6

Console.WriteLine("Digite o turno (1, 2 ou 3):");
int turno = int.Parse(Console.ReadLine());

switch (turno)
{
    case 1:
        Console.WriteLine("Manhã");
        break;
    case 2:
        Console.WriteLine("Tarde");
        break;
    case 3:
        Console.WriteLine("Noite");
        break;
    default:
        Console.WriteLine("Inválido");
        break;
}
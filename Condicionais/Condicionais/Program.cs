Console.WriteLine("Estruturas condicionais");

//Estruturas condicionais
// if simples/composto

int numero = 5;

if (numero >= 10)
{
    Console.WriteLine("O if foi executado com sucesso! ");
}
else
{
    Console.WriteLine("Fim do programa");
}

Console.WriteLine("Informe um número: ");
int num = int.Parse(Console.ReadLine());

// if encadeado (if - else if - else)
// se o numero é negativo
// se é positivo
// ou se é neutro (0)


if (num < 0)
{
    Console.WriteLine($"O número: {num} é negativo!"); // interpolação ou concatenação
}
else if (num > 0)
{
    Console.WriteLine($"O número: {num} é positivo! ");
}
else if (num == 0)
{
    Console.WriteLine($"O número: {num} é neutro! ");
}
else
{
    Console.WriteLine("Número inválido");
}


//com base nas informações, verifique se a pessoa pode votar */

// entrada
Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Possui titulo? s/n");
char titulo = char.Parse(Console.ReadLine());

if (idade >= 18 && idade <= 70)
{
    Console.WriteLine("O voto é obrigatório! ");
}
if (titulo != 's')
{
    Console.WriteLine("Antes de votar, você deve fazer o titulo de eleitor! ");

}

else if (idade < 16)
{
    Console.WriteLine("Não pode votar");
}
else
{
    Console.WriteLine("O voto é facultativo! ");
}



//// leia uma nota de 0 a 10(aceita decimais) sem deixar o programa quebrar
//// Use o double.TryParse no lugar de double.Parse.
//// Texto que não é numero -> Entrada inválida: digite um número
//// fora de 0 a 10 -> Nota fora da faixa (0 a 10)
//// 9 ou mais -> Conceito A; 7 ou mais -> Conceito B; 5 ou mais -> Conceito C
//// abaixo de 5 -> Conceito D


Console.WriteLine("Digite uma nota (0 a 10):");
string textoNota = Console.ReadLine();

if (!double.TryParse(textoNota, out double notaConceito))
{
    Console.WriteLine("Entrada inválida: digite um número");
}
else if (notaConceito < 0 || notaConceito > 10)
{
    Console.WriteLine("Nota fora da faixa (0 a 10)");
}
else if (notaConceito >= 9)
{
    Console.WriteLine("Conceito A");
}
else if (notaConceito >= 7)
{
    Console.WriteLine("Conceito B");
}
else if (notaConceito >= 5)
{
    Console.WriteLine("Conceito C");
}
else
{
    Console.WriteLine("Conceito D");
}

////// leia a idade, se é estudante (s/n), o dia da semana (1 = domingo ... 7 = sábado)
////// e se a sessão é 3d (s/n). Calcule o preço:
//////1. preço base: R$ 40, 00.
//////2. meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante
//////3. as terças-feiras (dia 3), mais 20% de desconto sobre o valor já calculado
////// 4. sessão 3d: soma R$ 8,00 depois dos descontos 
//////idade fora de 0 a 120 -> "idade inválida". Dia fora de 1 a 7 -> "Dia inválido".

//entrada
Console.WriteLine("Digite a idade:");
int idadeCinema = int.Parse(Console.ReadLine());

Console.WriteLine("É estudante? (s/n)");
string estudanteCinema = Console.ReadLine();

Console.WriteLine("Dia da semana (1 = domingo ... 7 = sábado):");
int diaCinema = int.Parse(Console.ReadLine());

Console.WriteLine("Sessão 3D? (s/n)");
string sessao3D = Console.ReadLine();
// processamento
if (idadeCinema < 0 || idadeCinema > 120)
{
    Console.WriteLine("Idade inválida");
    return;
}
else if (diaCinema < 1 || diaCinema > 7)
{
    Console.WriteLine("Dia inválido");
    return;
}
else
{
    decimal precoIngresso = 40.00m;

    if (idadeCinema < 12 || idadeCinema >= 60 || estudanteCinema == "s")
    {
        precoIngresso *= 0.50m;
    }

    if (diaCinema == 3)
    {
        precoIngresso *= 0.80m;
    }

    if (sessao3D == "s")
    {
        precoIngresso += 8.00m;
    }
    // saida
    Console.WriteLine($"Preço final: R$ {Math.Round(precoIngresso, 2)}");
}

//leia o limite da via e a velocidade medida (km/h, inteiros)
//calcule o percentual acima do limite com
// velocidade - limite) * 100.0 / limite e classifique com uma switch expression
//regras simplificadas, inspiradas no código de trânsito:
// 0% ou menos -> dentro do limite
// ate 20% -> infração média
// acima de 20% ate 50% -. infração grave
//acima de 50 -> infração gravissima 
//limite menor ou igual a 0, ou velocidade negativa -> dados inválidos

Console.WriteLine("Digite o limite da via (km/h):");
int limiteVia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a velocidade medida (km/h):");
int velocidadeMedida = int.Parse(Console.ReadLine()!);

if (limiteVia <= 0 || velocidadeMedida < 0)
{
    Console.WriteLine("Dados inválidos");
    return;
}
    double percentualExcesso = (velocidadeMedida - limiteVia) * 100.0 / limiteVia;


    // switch expression
    string classificacaoInfracao = percentualExcesso switch
    {
        <= 0 => "Dentro do limite",
        <= 20 => "Infração média",
        <= 50 => "Infração grave",
        _ => "Infração gravíssima"
};


if (percentualExcesso <= 0)
{
    Console.WriteLine(classificacaoInfracao);
} else
{
    Console.WriteLine($"Percentual acima do limite: {percentualExcesso:F1}%");
}
    

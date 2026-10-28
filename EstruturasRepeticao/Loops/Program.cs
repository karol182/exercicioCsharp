//Console.WriteLine("Estruturas de Repetição!");


////for (variavel; condição; incremento)

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

////while
////criar um programa que pergunte a idade do pericles


////Console.WriteLine("Informe a idade do Pericles");
////int idadePericles = int.Parse(Console.ReadLine());

////while(idadePericles != 57)
////{
////    Console.WriteLine("Errou, tente novamente! ");
////    // if tenario
////    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");
////    idadePericles = int.Parse(Console.ReadLine());
////}

////Console.WriteLine("Você acertou!");

//// do while 

//int idadePericles;
//do
//{
//    Console.WriteLine("Informe a idade do Pericles");
//    idadePericles = int.Parse(Console.ReadLine());

//if (idadePericles == 57)
//    {
//        Console.WriteLine("Você acertou!");
//        break;
//    }
//    // if tenario
//    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor" : "Tente uma idade maior");

////} while (idadePericles != 57);

//// foreach

//string [] nomes = {"Karol", "Gustavo", "Guilherme", "Bianca", "Dayane"};
//try
//{
//    Console.WriteLine(nomes[2]);
//    foreach (string nome in nomes)
//    {

//    }
//} catch(IndexOutOfRangeException)
//{
//    Console.WriteLine("o index está fora do alcance! ");
//}

//// for (int i = 0; i < nomes.Length; i++)
//// Console.WriteLine(nomes[i]);


//int[] numeros = { 2, 4, 6, 8 };
//int soma = 0;

//foreach (int n in numeros)
//{
//    soma += n;
//}

//Console.WriteLine("Soma: " + soma);

//crie um programa que vai pedir um numero para o usuário 
// e o programa deve mostrar a tabuada desse número da seguinte maneira:
// 5x1 = 5
// 5x2 = 10
// 5x10 = 50

Console.WriteLine("Digite um número:");
int numTabuada = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numTabuada} x {i} = {numTabuada * i}");
}
//Array -> Estrutura de dados unidimensional 
// -> aceitar um único tipo de dados (int, string, objeto
// -> estrutura (coleção) de tamanho fixo
// que é definida no momento da criação


// criação

int[] valores = { 15, 20, 36 };
Console.WriteLine(valores[0]);


int[] valores2 = new int[5]; // 0,1,2,3,4

//valores2[0]= int.Parse(Console.ReadLine()!);

for (int i = 0; i < valores2.Length; i++)
{
    Console.WriteLine($"Informe o {i+1} valor: ");
    valores2[i] = int.Parse(Console.ReadLine()!);
}

foreach (var v2 in valores2)
{
    Console.WriteLine("\n" + v2);
}
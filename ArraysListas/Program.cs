//Array -> Estrutura de dados unidimensional 
// -> aceitar um único tipo de dados (int, string, objeto
// -> estrutura (coleção) de tamanho fixo
// que é definida no momento da criação


//// criação

//int[] valores = { 15, 20, 36 };
//Console.WriteLine(valores[0]);


//int[] valores2 = new int[5]; // 0,1,2,3,4

////valores2[0]= int.Parse(Console.ReadLine()!);

//for (int i = 0; i < valores2.Length; i++)
//{
//    Console.WriteLine($"Informe o {i+1} valor: ");
////    valores2[i] = int.Parse(Console.ReadLine()!);
////}

////foreach (var v2 in valores2)
////{
////    Console.WriteLine("\n" + v2);
////}

////Listas
//List<int> list = new List<int> {10, 15, 20, 25};

//foreach (var l in list)
//{
//    Console.WriteLine(l);
//}
//Console.WriteLine($"Comprimento atual da lista:{list.Count}");

//list[1] = 22;
//list[4] = 30;


////MÉTODOS DE LISTAS
////adicionar valores dentro de listas(add, insert)

//list.Add(30); // sempre vai adicionar no final da lista
//list.Insert(1, 23);

//// REMOVE (valores dentro de listas: remove, removeAt, removeAll, clear)
//list.Remove(20);
//list.RemoveAll(x => x == 22);
//list.RemoveAt(5);


////buscar e consultar -> verificar se algo (valor) existe
//// contais, indexOf, find, findIndex, exists, findAll
//Console.WriteLine(list.Contains(25));
//Console.WriteLine(list.IndexOf(25));
//Console.WriteLine(list.Find(x => x == 25));
//Console.WriteLine(list.FindIndex(x => x == 25));
//Console.WriteLine(list.FindAll(x => x == 22));
//Console.WriteLine(list.Exists(x => x == 22));


////MÉTODOS DE ORDENAÇÃO 
//// sort, reverse
//list.Sort();
//list.Reverse();

//// MÉTODOS
//// count
//list.Count();

//foreach (var l in list)
//{
//    Console.WriteLine(l);
//}
//Console.WriteLine($"Comprimento atual da lista:{list.Count}");


//criar um programa para manipulação de dados usando listas
// 1. criar uma listas de frutas 
//2. add, remover, verificar se um elemento está na lista, atualizar uma fruta existente
// para isso, utilize as estruturas (se necessário) if, else, else if, while, for, foreach do while e os metodos de listas

List<string> frutas = new List<string> {"laranja","uva" ,"manga","cereja","banana"};

//add
frutas.Add("goiaba");

//remove
frutas.Remove("banana");

//contém

Console.WriteLine(frutas.Contains("uva"));

foreach (var f in frutas)
{
    Console.WriteLine($"A lista atual de frutas:{f}");
}


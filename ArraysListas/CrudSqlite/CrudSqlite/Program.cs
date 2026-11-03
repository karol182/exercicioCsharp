using Microsoft.Data.Sqlite;

// Verificar a conexão com o banco de dados
// Criar a tabela para trabalhar com a persistência dos dados

var conn = new SqliteConnection("Data Source = frutas.db");
conn.Open();

// Criação da Tabela
var criarTabela = conn.CreateCommand();
criarTabela.CommandText = @"CREATE TABLE IF NOT EXISTS frutas (
                                idFruta INTEGER PRIMARY KEY AUTOINCREMENT,
                                nomeFruta TEXT NOT NULL UNIQUE)";

criarTabela.ExecuteNonQuery();

Console.WriteLine($"Banco frutas criado em: {Path.GetFullPath("frutas.db")}");

// ------- Menu --------
List<string> listaFrutas = new List<string>();

int opcao;
do
{
    MostrarMenu();
    string entrada = Perguntar("Opção: ");
    if (!int.TryParse(entrada, out opcao))
    {
        opcao = -1;
    }
    switch (opcao)
    {
        case 1:
            ListarFrutas();
            break;
        case 2:
            AdicionarFrutas();
            break;
        case 3:
            AtualizarFrutas();
            break;
        case 4:
            RemoverFrutas();
            break;
        case 5:
            VerificarFrutas();
            break;
        case 6:
            OrdenarFrutas();
            break;
        case 0:
            Console.WriteLine("Até mais");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
while (opcao != 0);

conn.Close();

// ------- Funções --------

// Lê as frutas do banco e devolve numa lista
List<string> CarregarFrutas(string ordenarPor)
{
    List<string> listaFrutas = new List<string>();

    var selecionarFrutas = conn.CreateCommand();
    selecionarFrutas.CommandText = $"SELECT nomeFruta FROM frutas ORDER BY {ordenarPor} ASC";

    var leitor = selecionarFrutas.ExecuteReader();
    while (leitor.Read())
    {
        listaFrutas.Add(leitor.GetString(0));
    }
    leitor.Close();

    return listaFrutas;
}

void MostrarLista(List<string> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("Não tem nada na lista");
    }

    foreach (var f in lista)
    {
        Console.WriteLine(f);
    }
}

void ListarFrutas()
{
    // na ordem em que foram adicionadas
    MostrarLista(CarregarFrutas("idFruta"));
}

void OrdenarFrutas()
{
    // de A a Z
    MostrarLista(CarregarFrutas("nomeFruta"));
}

void AdicionarFrutas()
{
    Console.WriteLine("Informe o nome da fruta nova: ");
    string frutaNova = Console.ReadLine()!.Trim();

    if (frutaNova == "")
    {
        Console.WriteLine("O nome não pode ficar vazio!");
    }
    else if (listaFrutas.Contains(frutaNova))
    {
        Console.WriteLine("A lista já possui essa fruta");
    }
    else
    {
        var inserir = conn.CreateCommand();
        inserir.CommandText = "INSERT INTO frutas (nomeFruta) VALUES ($nomeFruta)";
        inserir.Parameters.AddWithValue("$nomeFruta", frutaNova);
        inserir.ExecuteNonQuery();

        Console.WriteLine($"{frutaNova} adicionada!");
    }
}

void AtualizarFrutas()
{
    List<string> listaFrutas = CarregarFrutas("nomeFruta");

    Console.WriteLine("Informe a fruta que quer atualizar: ");
    string frutaAntiga = Console.ReadLine()!.Trim();

    if (!listaFrutas.Contains(frutaAntiga))
    {
        Console.WriteLine("Essa fruta não está na lista");
    }
    else
    {
        Console.WriteLine("Informe o novo nome: ");
        string frutaNova = Console.ReadLine()!.Trim();

        if (frutaNova == "")
        {
            Console.WriteLine("O nome não pode ficar vazio!");
        }
        else if (listaFrutas.Contains(frutaNova))
        {
            Console.WriteLine("A lista já possui uma fruta com esse nome");
        }
        else
        {
            var atualizar = conn.CreateCommand();
            atualizar.CommandText = "UPDATE frutas SET nomeFruta = $novo WHERE nomeFruta = $antiga";
            atualizar.Parameters.AddWithValue("$novo", frutaNova);
            atualizar.Parameters.AddWithValue("$antiga", frutaAntiga);
            atualizar.ExecuteNonQuery();

            Console.WriteLine($"{frutaAntiga} foi trocada por {frutaNova}!");
        }
    }
}

void RemoverFrutas()
{
    List<string> listaFrutas = CarregarFrutas("nomeFruta");

    Console.WriteLine("Informe a fruta que quer remover: ");
    string frutaRemover = Console.ReadLine()!.Trim();

    if (!listaFrutas.Contains(frutaRemover))
    {
        Console.WriteLine("Essa fruta não está na lista");
    }
    else
    {
        var remover = conn.CreateCommand();
        remover.CommandText = "DELETE FROM frutas WHERE nomeFruta = $nomeFruta";
        remover.Parameters.AddWithValue("$nomeFruta", frutaRemover);
        remover.ExecuteNonQuery();

        Console.WriteLine($"{frutaRemover} removida!");
    }
}

void VerificarFrutas()
{
    Console.WriteLine("Informe a fruta que quer procurar: ");
    string frutaBuscar = Console.ReadLine()!.Trim();

    if (listaFrutas.Contains(frutaBuscar))
    {
        Console.WriteLine($"{frutaBuscar} está na lista");
    }
    else
    {
        Console.WriteLine($"{frutaBuscar} não está na lista");
    }
}

string Perguntar(string mensagem)
{
    Console.WriteLine(mensagem);
    return (Console.ReadLine()!.Trim()!);
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("===== FRUTAS =====");
    Console.WriteLine("[1] - Listar Frutas");
    Console.WriteLine("[2] - Adicionar Frutas");
    Console.WriteLine("[3] - Atualizar Frutas");
    Console.WriteLine("[4] - Remover Frutas");
    Console.WriteLine("[5] - Verificar se existe");
    Console.WriteLine("[6] - Ordenar Frutas");
    Console.WriteLine("[0] - Sair");
}
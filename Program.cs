Console.WriteLine("***************************************************");

List<string> tarefas = new List<string>();

tarefas.Add("Acordar");
tarefas.Add("Escola");
tarefas.Add("Almoçar");
tarefas.Add("casa");
tarefas.Add("academia das maravilhas");
tarefas.Add("dormir");

tarefas.Insert(2, "Me arrumar");

tarefas[4] = "fazer a janta";

bool achou = tarefas.Contains("dormir");
if (achou)
{
    Console.WriteLine("Tarefa encontrada!");
}
else
{
    Console.WriteLine("Tarefa não encontrada!");

    tarefas.Remove("Escola");

    foreach (string item in tarefas)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("***************************************************");
    Dictionary<int, string> telefone = new Dictionary<int, string>();

    telefone.Add(123456789, "João");
    telefone.Add(987654321, "Maria");
    telefone.Add(456789123, "Pedro");
    telefone.Add(789123456, "Ana");
    telefone.Add(321654987, "Carla");

    Console.WriteLine("\nEncontre o número que deseja buscar: ");
    foreach (KeyValuePair<int, string> item in telefone)
    {
        Console.WriteLine($"Número: {item.Key} - Nome: {item.Value}");
    }

    Console.WriteLine("\nImprimindo o número que desejou buscar");
    foreach (var item in telefone)
    {
        Console.WriteLine($"Numero:{item.Key}| Nome: {item.Value}");
    }
    Console.WriteLine("\nAlterando o numero da agenda");

    bool numeroEncontrado = telefone.TryGetValue(123456789, out string nome);

    if (numeroEncontrado)
    {
        Console.WriteLine($"Numero encontrado para a Agenda é: {telefone}");
    }
    else
    {
        Console.WriteLine("Número não encontrado na agenda.");
    }

    telefone.Remove(987654321);
    foreach (var item in telefone)
    {
        Console.WriteLine($"Numero:{item.Key}| Nome: {item.Value}");
    }

    Console.WriteLine("*************************************************************");

    Queue<string> fila = new Queue<string>();
    fila.Enqueue("João");
    fila.Enqueue("Maria");
    fila.Enqueue("Pedro");
    fila.Enqueue("Ana");

    foreach (string item in fila)
    {
        Console.WriteLine(item);
    }

    string primeiroFila = fila.Dequeue();
    Console.WriteLine($"\n{primeiroFila} é o primeiro, e saiu da fila\n");

    foreach (var pessoa in fila)
    {
        Console.WriteLine(pessoa);
    }

    fila.Enqueue("Carla");
    Console.WriteLine("\n");

    bool encontrou = fila.Contains("Ana");

    if (encontrou)
    {
        Console.WriteLine("Pessoa encontrada na fila!");
    }
    else
    {
        Console.WriteLine("Pessoa não encontrada na fila!");
    }

    Console.WriteLine("*************************************************************");

    Stack<string> Paginas = new Stack<string>();
    Paginas.Push("Página 1");
    Paginas.Push("Página 2");
    Paginas.Push("Página 3");

    foreach (var item in Paginas)
    {
        Console.WriteLine(item);
    }

    string ultimaPagina = Paginas.Pop();
    Console.WriteLine($"\n{ultimaPagina} foi a última página visitada e foi removida do histórico.\n");

    foreach (var pagina in Paginas)
    {
        Console.WriteLine(pagina);
    }

    if (Paginas.Contains("Página 2"))
    {
        Console.WriteLine("\nPágina 2 está no histórico.");
    }
    else
    {
        Console.WriteLine("\nPágina 2 não está no histórico.");
    }
    Console.WriteLine("*************************************************************");

}

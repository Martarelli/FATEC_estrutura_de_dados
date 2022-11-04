tp_no lista = null;
string op = "1";
string op2 = "";
string nome, idade, whats = "";

while (op != "0")
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Inserir Cadastro");
    Console.WriteLine("2 - Alterar Cadastro");
    Console.WriteLine("3 - Excluir Cadastro");
    Console.WriteLine("4 - Exibir Cadastro");
    Console.WriteLine("0 - Sair");

    Console.Write("Digite a opção desejada: ");
    op2 = Console.ReadLine();

    if (op2 == "1")
    {
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite a idade: ");
        idade = Console.ReadLine();
        Console.Write("Digite o zapzap: ");
        whats = Console.ReadLine();

        Insere(ref lista, nome, idade, whats);

    }
    else if (op2 == "2")
    {

    }
    else if (op2 == "3")
    {

    }
    else if (op2 == "4")
    {

    }
    else if (op2 == "0")
    {
        Console.WriteLine("Encerrando a aplicação....");
        op = "0";
    }
    else
    {
        Console.WriteLine("Opção inválida... Tente novamente...");
    }


}


void Insere(ref tp_no l, string n, string i, string w)
{
    tp_no no = new tp_no();
    no.nome = n;
    no.idade = i;
    no.whats = w;
    if (l != null)
        no.prox = l;
    l = no;
}

tp_no Remove(ref tp_no l)
{
    tp_no no = null;
    if (l != null)
    {
        no = l;
        l = l.prox;
        no.prox = null;
    }
    return no;
}

class tp_no
{
    public string nome, idade, whats;
    public tp_no prox;
}



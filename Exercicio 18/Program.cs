﻿tp_no lista = null;
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
        alterar(lista);
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

void consulta(tp_no l, string np, ref tp_no ant, ref tp_no atu)
{
    ant = null;
    atu = l;
    while (atu != null && np != atu.nome)
    {
        ant = atu;
        atu = atu.prox;
    }
}

void alterar(tp_no l)
{
    string np;
    tp_no atual = null;
    tp_no anterior = null;
    Console.Write("Digite o nome para consulta: ");
    np = Console.ReadLine();
    consulta(lista, np, ref anterior, ref atual);
    if (atual != null)
    {
        Console.WriteLine("Dados Atuais");
        Console.WriteLine("Nome: " + atual.nome);
        Console.WriteLine("Idade: " + atual.idade);
        Console.WriteLine("Zapzap: " + atual.whats);
        Console.WriteLine("Digite os novos dados");
        Console.Write("Nome:");
        atual.nome = Console.ReadLine();
        Console.Write("Idade");
        atual.idade = Console.ReadLine();
        Console.Write("Zapzap:");
        atual.whats = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Cadastro não encontrado :( ...")
    }



}
class tp_no
{
    public string nome, idade, whats;
    public tp_no prox;
}



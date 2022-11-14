// 17) Faça uma implementação que construa uma lista encadeada. Seu programa deve ter as opções de inserção e remoção dos elementos. Após remover um elemento da lista, exiba-o na tela.

string op = "1";
int x;
tp_no lista = null;
tp_no elemento = null;
while (op != "0")
{
    Console.WriteLine("1 - Adicionar na lista");
    Console.WriteLine("2 - Remover da lista"); 
    Console.WriteLine("0 - Sair"); 
    Console.Write("Escolha uma opção: ");

    op = Console.ReadLine();

    if (op == "1")
    {
        Console.Write("Digite o número que deseja adicionar: ");
        x = Convert.ToInt32(Console.ReadLine());
        Insere(ref lista, x);
    }
    else if (op == "2")
    {
        elemento = Remove(ref lista);
        if (elemento != null)
        {
            Console.WriteLine("Valor removido: " + elemento.valor);
        }
        else
        {
            Console.WriteLine("Lista vazia");
        }
    }

}

void Insere(ref tp_no l, int v)
{
    tp_no no = new tp_no();
    no.valor = v;
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
    public int valor;
    public tp_no prox;
}

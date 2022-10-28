// 17) Faça uma implementação que construa uma lista encadeada. Seu programa deve ter as opções de inserção e remoção dos elementos. Após remover um elemento da lista, exiba-o na tela.

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

tp_no lista = null;

class tp_no
{
    public int valor;
    public tp_no prox;
}


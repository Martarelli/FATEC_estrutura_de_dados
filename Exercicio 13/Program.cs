const int MAX = 20;
int[] fila = new int[MAX];
int inicio = 0, fim = 0;
int[] filaMa = new int[MAX];
int iMa = 0, fMa = 0;
int[] filame = new int[MAX];
int ime = 0, fme = 0;

int V , VD;
V = 1;

bool EstaVazia(int i, int f)
{
    if (i == f)
        return true;
    else
        return false;
}

bool EstaCheia(int f)
{
    if (f == MAX)
        return true;
    else
        return false;
}

void Insere(int[] q, ref int f, int v)
{
    q[f] = v;
    f = f + 1;
}

int Remove(int[] q, ref int i)
{
    int v = q[i];
    i = i + 1;
    return (v);
}


while (V != 0)
{
    Console.WriteLine("Digite um valor: ");
    V = Convert.ToInt32(Console.ReadLine());

    if (EstaCheia(fim) == false)
    {
        Insere(fila, ref fim, V);
    } 
    else
    {
        Console.WriteLine("Fila cheia");
        V = 0;
    }
}
Console.WriteLine("Digite o valor divisor");
VD = Convert.ToInt32(Console.ReadLine());
while(!EstaVazia(inicio,fim))
{
    V = Remove(fila, ref inicio);
    if (V >= VD)
    {
        Insere(filaMa, ref fMa, V);
    }
    else
    {
        Insere(filame, ref fme, V);
    }
}

Console.WriteLine("Fila com número maiores que " + VD);
while (!EstaVazia(iMa, fMa)){
    Console.WriteLine(Remove(filaMa, ref iMa));
}

Console.WriteLine("Fila com número menores que " + VD);
while (!EstaVazia(ime, fme)){
    Console.WriteLine(Remove(filame, ref ime));
}
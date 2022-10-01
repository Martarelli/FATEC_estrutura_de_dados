// 15) Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. Os aviões são identificados pelos números digitados pelo usuário. Neste programa, o usuário deve ser capaz de realizar as seguintes operações:
// a) Adicionar vários aviões à fila de espera para decolagem
// b) Consultar a quantidade de aviões aguardando na fila
// c) Autorizar a decolagem de um avião da fila
// d) Listar os números de todos os aviões na fila
// e) Consultar o número do primeiro avião da fila
// Construa um menu principal para oferecer essas operações ao usuário.


const int MAX = 20;

int[] fila = new int[MAX];
int inicio = 0, fim = 0;

bool ligado = true;
string op;

while (ligado)
{
    Console.WriteLine("\n***********CONTROLE DE PISTA***********\n");
    Console.WriteLine("1 - Adicionar avião na fila");
    Console.WriteLine("2 - Consultar quantidade de aviões na fila");
    Console.WriteLine("3 - Autorizar decolagem");
    Console.WriteLine("4 - Consultar id dos aviões na fila");
    Console.WriteLine("5 - Consultar o primeiro avião da fila");
    Console.Write("\nDigite a opção desejada: ");
    op = Console.ReadLine();

    if (op == "1")
    {
        adicionar();
    } 
    else if(op == "2")
    {
        qtdFila();
    }
    else if(op == "3")
    {
        autorizacao();
    }
    else if(op == "4")
    {
        consultarIds();
    }
    else if(op == "5")
    {
        consultarPrimeiroId();
    } 
    else
    {
        Console.WriteLine("Desligando a aplicação.....");
        ligado = false;
    }  
}

void adicionar(){
    Console.WriteLine("\n***ADICIONAR AVIÃO NA FILA***\n");
    Console.Write("Digite o ID do avião que deseja adicionar: ");
    int id = Convert.ToInt32(Console.ReadLine());
    if (!EstaCheia(fim))
    {
        Insere(fila, ref fim, id);
        Console.WriteLine("Avião ID {0} adicionado a fila com sucesso.....", id);
    } 
    else 
    {
        Console.WriteLine("FILA CHEIA - Não foi possível adicionar o avião a fila.....");
    }
}

void qtdFila(){
    Console.WriteLine("***\nCONSULTA DA QUANTIDADE DE AVIÕES NA FILA***\n");
    int qtd = fim - inicio;
    Console.WriteLine(qtd + " aviões na fila de espera.....");
}

void autorizacao(){
    Console.WriteLine("\n***AUTORIZAÇÃO DE DECOLAGEM***\n");
    Console.WriteLine("Deseja autorizar a decolagem do avião ID {0}? S - Sim / N - não",fila[inicio]);
    Console.Write("Digite a opção desejada: ");
    string autorizado = Console.ReadLine();
    if (autorizado == "S" || autorizado == "s")
    {
        int aviaoAutorizado = Remove(fila, ref inicio);
        Console.WriteLine("Avião ID {0} autorizado a decolagem.....", aviaoAutorizado);
    }
    else
    {
        Console.WriteLine("Nenhum avião foi autorizado a decolar.....");
    }
}

void consultarIds(){
    Console.WriteLine("***\nCONSULTA ID DOS AVIÕES NA FILA***\n");
}
void consultarPrimeiroId(){
    Console.WriteLine("***\nCONSULTA PRIMEIRO AVIÃO DA FILA***\n");
}

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



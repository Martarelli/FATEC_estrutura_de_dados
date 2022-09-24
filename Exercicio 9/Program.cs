// See https://aka.ms/new-console-template for more information
int topo = 0;

const int MAX = 20;
char[] pile = new char[MAX];

void Insere(char[] p, ref int t, char v)
{
    p[t] = v;
    t = t + 1;
}

char Remove(char[] p, ref int t)
{
    t = t - 1;
    return (p[t]);
}

string nome = "Jose da Silva";
int i = 0;
while (i < nome.Length - 1 ){
    while(nome[i] != ' ' && i < nome.Length){
        Insere(pile, ref topo, nome[i]);
        i++;
    }
    while(topo > 0){
        char c = Remove(pile, ref topo);
        Console.Write(c);
    }
    Console.Write(' ');
    i++;
} 

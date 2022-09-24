const int MAX = 20;
char[] pile = new char[MAX];
int topo = 0;

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

string frase = "";
Console.Write("Digite uma frase: ");
frase = Console.ReadLine();
frase = String.Format("{0} ",frase);
int i = 0;
while (i < frase.Length - 1)
{
    while (frase[i] != ' ' && i < frase.Length)
    {
        Insere(pile, ref topo, frase[i]);
        i++;
    }

    while (topo > 0)
    {
        char c = Remove(pile, ref topo);
        Console.Write(c);
    }
    Console.Write(' ');

    i++;

}

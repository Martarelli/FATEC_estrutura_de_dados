// 28) Implemente um programa com as seguintes opções: Sem tratamento de colisão, Tratamento de colisão Linear e Tratamento de colisão com Lista Encadeada.
// 	Dentro de cada opção deve haver as funcionalidades: Inserir, Alterar e Relatar.
// 	O vetor deve ser do tipo abstrato de dado composto por idade, nome e whats. Serão necessários 3 vetores, um para cada tipo de tratamento de colisão.
// Para inserir um novo registro, solicite a idade, nome e whats. Utilize a idade como chave.
// Para alterar solicite a idade (chave) para ser utilizada na busca. Caso encontrada, informe o nome e o whats da pessoa. Após a consulta, o usuário pode atualizar somente o nome e o whats.
// Para relatar, percorra o vetor do inicio ao fim e exiba todos os registros.

const int N = 5;
string op = "1", op2 = "1";
int valor, pos;
tp_no no = null;

while (op != "0")
{
    Console.WriteLine("MENU PRINCIPAL\n");
    Console.WriteLine("1 - Sem tratamento de colisão");
    Console.WriteLine("2 - Tratamento de colisão Linear");
    Console.WriteLine("3 - Tratamento de colisão com Lista Encadeada");
    Console.WriteLine("0 - Sair");

    Console.Write("Digite a opção desejada: ");
    op = Console.ReadLine();

    if (op == "1")
    {
      int[] vetorSemTratamento = new int[N];
      op2 = "1";
      while (op2 != "0")
      {
         Console.WriteLine("\nSEM TRATAMENTO DE COLISÃO\n");
         Console.WriteLine("1 - Inserir Valor");
         Console.WriteLine("2 - Alterar Valor");
         Console.WriteLine("3 - Exibir Valores");
         Console.WriteLine("0 - Sair");

         Console.Write("\nDigite a opção desejada: ");
         op2 = Console.ReadLine();

         if (op2 == "1")
         {
            Console.Write("\nValor a ser adicionado: ");
            valor = Convert.ToInt32(Console.ReadLine());
            InsereSemTratamento(vetorSemTratamento,valor);
         }
         else if (op2 == "2")
         {
            Console.Write("\nValor a ser alterado: ");
            valor = Convert.ToInt32(Console.ReadLine());
            pos = BuscaSemTratamento(valor);
            if (vetorSemTratamento[pos] == valor)
            {
               Console.Write("\nNovo Valor: ");
               valor = Convert.ToInt32(Console.ReadLine());
               vetorSemTratamento[pos] = 0;
               InsereSemTratamento(vetorSemTratamento,valor);
               Console.WriteLine("Valor alterado com sucesso");
            }
            else
            {
              Console.WriteLine("Valor não encontrado");
            }
         }
         else if (op2 == "3")
         {
            foreach(int i in vetorSemTratamento){
               Console.WriteLine(i);
            }
         }
         else if (op2 == "0")
         {
            Console.WriteLine("Saindo do modulo da aplicação....");
         }
         else
         {
            Console.WriteLine("Opção inválida... Tente novamente...");
         }
      }
    }
    else if (op == "2")
    {
      int[] vetorTratLinear = new int[N];
      op2 = "1";
      while (op2 != "0")
      {
         Console.WriteLine("\nTRATAMENTO DE COLISÃO LINEAR\n");
         Console.WriteLine("1 - Inserir Valor");
         Console.WriteLine("2 - Alterar Valor");
         Console.WriteLine("3 - Exibir Valores");
         Console.WriteLine("0 - Sair");

         Console.Write("\nDigite a opção desejada: ");
         op2 = Console.ReadLine();

         if (op2 == "1")
         {
            Console.Write("\nValor a ser adicionado: ");
            valor = Convert.ToInt32(Console.ReadLine());
            InsereLinear(vetorTratLinear,valor);
         }
         else if (op2 == "2")
         {
            Console.Write("\nValor a ser alterado: ");
            valor = Convert.ToInt32(Console.ReadLine());
            pos = BuscaLinear(vetorTratLinear, valor);
            if (pos != -1)
            {
               Console.Write("\nNovo Valor: ");
               valor = Convert.ToInt32(Console.ReadLine());
               vetorTratLinear[pos] = 0;
               InsereLinear(vetorTratLinear,valor);
               Console.WriteLine("Valor alterado com sucesso");
            }
            else
            {
              Console.WriteLine("Valor não encontrado");
            }
         }
         else if (op2 == "3")
         {
            foreach(int i in vetorTratLinear){
               Console.WriteLine(i);
            }
         }
         else if (op2 == "0")
         {
            Console.WriteLine("Saindo do modulo da aplicação....");
         }
         else
         {
            Console.WriteLine("Opção inválida... Tente novamente...");
         }
      }
    }
    else if (op == "3")
    {
      tp_no[] vetorTratLista = new tp_no[N];
      op2 = "1";
      while (op2 != "0")
      {
         Console.WriteLine("\nTRATAMENTO DE COLISÃO COM LISTA ENCADEADA\n");
         Console.WriteLine("1 - Inserir Valor");
         Console.WriteLine("2 - Alterar Valor");
         Console.WriteLine("3 - Exibir Valores");
         Console.WriteLine("0 - Sair");

         Console.Write("\nDigite a opção desejada: ");
         op2 = Console.ReadLine();

         if (op2 == "1")
         {
            Console.Write("\nValor a ser adicionado: ");
            valor = Convert.ToInt32(Console.ReadLine());
            InsereEncadeado(vetorTratLista, valor);
         }
         else if (op2 == "2")
         {
            Console.Write("\nValor a ser alterado: ");
            valor = Convert.ToInt32(Console.ReadLine());
            no = BuscaEncadeada(vetorTratLista, valor);
            if (no != null)
            {
               Console.Write("\nNovo Valor: " + no.chave + no.prox);
               valor = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
              Console.WriteLine("Valor não encontrado");
            }
         }
         else if (op2 == "3")
         {
            ExibirListaEncadeada(vetorTratLista);
         }
         else if (op2 == "0")
         {
            Console.WriteLine("Saindo do modulo da aplicação....");
         }
         else
         {
            Console.WriteLine("Opção inválida... Tente novamente...");
         }
      }
    }
    else if (op == "0")
    {
        Console.WriteLine("Encerrando a aplicação....");
    }
    else
    {
        Console.WriteLine("Opção inválida... Tente novamente...");
    }
}


int Hash(int chave)
{
   return (chave % N);
}



void InsereSemTratamento(int[] v, int c)
{
   int pos = Hash(c);
   v[pos] = c;
}

int BuscaSemTratamento(int c)
{
   int pos = Hash(c);
   return pos;
}


void InsereLinear(int[] v, int c)
{
   int pos = Hash(c);
   while (v[pos]  != 0)
   {
      pos++;
      pos = pos % N;
   }
   v[pos] = c;
}

int BuscaLinear(int[] v, int c)
{
   int qtd = 0;
   int pos = Hash(c);
   while (v[pos] != c && qtd < N)
   {
      pos++;
      pos = pos % N;
      qtd++;
   }
   if (qtd < N)
   {
      return pos;   
   }
   else
   {
      return -1;
   }
}



void InsereEncadeado(tp_no[] v, int c)
{
   tp_no no = new tp_no();
   no.chave = c;
   int pos = Hash(c);
   if (v[pos] != null)
      no.prox = v[pos];
   v[pos] = no;
}

tp_no BuscaEncadeada(tp_no[] v, int c)
{
   tp_no x = null;
   int pos = Hash(c);
   for (int i = 0; i < N; i++)
   {
      if (v[i] != null)
      {
         x = BuscaListaEncadeada(v[i], c);
      } 
      if (x != null && x.chave == c)
      {
         return x;
      }
   }
   return null;
}

tp_no BuscaListaEncadeada(tp_no r, int x)
{
   if (r == null)
      return null;
   else if (x == r.chave)
      return r;
   else
      return BuscaListaEncadeada(r.prox, x);
}

void ExibirListaEncadeada(tp_no[] r)
{
   tp_no x = null;
   for (int i = 0; i < N; i++)
   {
      if (r[i] != null)
      {
         x = r[i];
         PreOrdem(x);
      } 
   }
}

void PreOrdem(tp_no r)
{
   if (r != null)
   {
      Console.WriteLine(r.chave);
      PreOrdem(r.prox);
   }
}


class tp_no
{
   public int chave;
   public tp_no prox;

}
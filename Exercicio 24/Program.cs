// 24) Desenvolva um programa para inserir, pesquisar, remover e exibir os valores de uma árvore binária. Observe as opções a seguir:
// a)	Inserir um valor digitado pelo usuário
// b)	Pesquisar um valor digitado pelo usuário. Exiba uma mensagem informando se encontrou ou não
// c)	Remover um valor digitado pelo usuário. Exiba a mensagem se removido com sucesso ou não encontrado
// d)	Exibir todos os valores da árvore em ordem, pré ordem ou pós ordem

tp_no raiz = null, x;
string op = "1";
string op2 = "";
string opExibicao = "";

int valor;

while (op != "0")
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Inserir Valor");
    Console.WriteLine("2 - Pesquisar Valor");
    Console.WriteLine("3 - Remover Valor");
    Console.WriteLine("4 - Exibir Valores");
    Console.WriteLine("0 - Sair");

    Console.Write("Digite a opção desejada: ");
    op2 = Console.ReadLine();

    if (op2 == "1")
    {
      Console.Write("Digite o Valor a ser adicionado: ");
      valor = Convert.ToInt32(Console.ReadLine());
      Insere(ref raiz, valor);
    }
    else if (op2 == "2")
    {
      Console.Write("Digite o Valor a ser consultado: ");
      valor = Convert.ToInt32(Console.ReadLine());
        
    }
    else if (op2 == "3")
    {
      Console.Write("Digite o Valor a remover: ");
      valor = Convert.ToInt32(Console.ReadLine());
      x = Remove(ref raiz, valor);
      if (x != null)
      {
         Console.WriteLine("Valor removido com sucesso");
      }
      else
      {
         Console.WriteLine("Valor não foi removido");
      }

    }
    else if (op2 == "4")
    {
      Console.WriteLine("1- Pré Ordem / 2- Pós Ordem");
      Console.Write("Digite a opção desejada: ");
      opExibicao = Console.ReadLine();
      if (opExibicao == "1")
      {
         PreOrdem(raiz);
      }
      else if (opExibicao == "2")
      {
         PosOrdem(raiz);
      }
      else
      {
         Console.WriteLine("Opção inválida...");
      }
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


void Insere(ref tp_no r, int x)
{
   if (r == null)
   {
      r = new tp_no();
      r.valor = x;
   }
   else if (x < r.valor)
      Insere(ref r.esq, x);
   else
      Insere(ref r.dir, x);
}

tp_no Busca(tp_no r, int x)
{
   if (r == null)
      return null;
   else if (x == r.valor)
      return r;
   else if (x < r.valor)
      return Busca(r.esq, x);
   else
      return Busca(r.dir, x);
}

tp_no Remove(ref tp_no r, int x)
{
   if (r == null)
      return null;     
   else if (x == r.valor)
   {       
      tp_no p = r;
      if (r.esq == null)        // nao tem filho esquerdo
         r = r.dir;
      else if (r.dir == null)  // nao tem filho direito
         r = r.esq;
      else                          // tem ambos os filhos
      {
         p = RetornaMaior(ref r.esq);
         r.valor = p.valor;
      }
      return p;
   }
   else if (x < r.valor)
      return Remove(ref r.esq, x);
   else
      return Remove(ref r.dir, x);
}

tp_no RetornaMaior(ref tp_no r)
{
   if (r.dir == null)
   {
      tp_no p = r;
      r = r.esq;
      return p;
   }
   else
      return RetornaMaior(ref r.dir);
}

void PreOrdem(tp_no r)
{
   if (r != null)
   {
      Console.WriteLine(r.valor);
      PreOrdem(r.esq);
      PreOrdem(r.dir);
   }
}

void PosOrdem(tp_no r)
{
   if (r != null)
   {
      PosOrdem(r.esq);
      PosOrdem(r.dir);
      Console.WriteLine(r.valor);
   }
}


class tp_no
{
   public tp_no esq;
   public int valor;
   public tp_no dir;

}
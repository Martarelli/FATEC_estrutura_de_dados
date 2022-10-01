// 15) Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. Os aviões são identificados pelos números digitados pelo usuário. Neste programa, o usuário deve ser capaz de realizar as seguintes operações:
// a) Adicionar vários aviões à fila de espera para decolagem
// b) Consultar a quantidade de aviões aguardando na fila
// c) Autorizar a decolagem de um avião da fila
// d) Listar os números de todos os aviões na fila
// e) Consultar o número do primeiro avião da fila
// Construa um menu principal para oferecer essas operações ao usuário.

bool ligado = true;
string op;

while (ligado)
{
    Console.WriteLine("***********CONTROLE DE PISTA***********");
    Console.WriteLine("1 - Adicionar avião na fila");
    Console.WriteLine("2 - Consultar quantidade de aviões na fila");
    Console.WriteLine("3 - Autorizar decolagem");
    Console.WriteLine("4 - Consultar id dos aviões na fila");
    Console.WriteLine("5 - Consultar o primeiro avião da fila");
    Console.WriteLine("Digite a opção desejada: ");
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
    Console.WriteLine("***ADICIONAR AVIÃO NA FILA***");
}
void qtdFila(){
    Console.WriteLine("***CONSULTA DA QUANTIDADE DE AVIÕES NA FILA***");
}
void autorizacao(){
    Console.WriteLine("***AUTORIZAÇÃO DE DECOLAGEM***");
}
void consultarIds(){
    Console.WriteLine("***CONSULTA ID DOS AVIÕES NA FILA***");
}
void consultarPrimeiroId(){
    Console.WriteLine("***CONSULTA PRIMEIRO AVIÃO DA FILA***");
}


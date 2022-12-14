string op = "0";
while (op != "3")
{
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Função sem vetor");
    Console.WriteLine("2 - Função com vetor");
    Console.WriteLine("3 - Sair");
    Console.Write("Digite a opção desejada: ");
    op = Console.ReadLine();

    if (op == "1"){
        int nI, nF;
        Console.Write("Numero Inicial: ");
        nI = int.Parse(Console.ReadLine());
        Console.Write("Numero Final: ");
        nF = int.Parse(Console.ReadLine());

        Console.WriteLine("MENU 2");
        Console.WriteLine("1 - Crescente");
        Console.WriteLine("2 - Decrescente");
        Console.WriteLine("3 - Impares");
        Console.WriteLine("4 - Somatório");
        string op2 = Console.ReadLine();
        if (op2 == "1"){
            Console.WriteLine("De " + nI + " até " + nF + " em ordem crescente:");
            crescente(nI, nF);
        } else if (op2 == "2"){
            Console.WriteLine("De " + nI + " até " + nF + " em ordem decrescente:");
            decrescente(nI, nF);
        } else if (op2 == "3"){
            Console.WriteLine("Números impares de " + nI + " até " + nF + ":");
            impares(nI, nF);
        } else if (op2 == "4"){
            Console.WriteLine("O somaatório de todos os números de " + nI + " até " + nF + ":");
            int soma = somatorio(nI, nF);
            Console.WriteLine("A soma foi: " + soma);
        }
    } else if (op == "2"){
        int[] vetor = new int[5];
        int i=0, n=1;
        while(n != 0 && i < vetor.Length){
            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            vetor[i] = n;
            i++;
        }
        Console.WriteLine(vetor);
        // int s = somaVetor(vetor, i);
        // Console.WriteLine(s);
    }
    Console.ReadKey();
}

void crescente(int nI, int nF){
    if (nI <= nF){
        Console.WriteLine(nI);
        crescente(nI+1,nF);
    }
}

void decrescente(int nI, int nF){
    if (nF >= nI){
        Console.WriteLine(nF);
        decrescente(nI,nF-1);
    }
}

void impares(int nI, int nF){
    if (nI <= nF){
        if (nI % 2 != 0){
            Console.WriteLine(nI);
        }
        impares(nI + 1, nF);
    }
}

int somatorio(int nI, int nF){
    if(nI < nF){
        return nI + somatorio(nI + 1, nF);
    } else {
        return nI;
    }
}


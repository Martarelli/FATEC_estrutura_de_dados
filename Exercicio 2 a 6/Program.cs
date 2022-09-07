// Crie um novo projeto para desenvolver um programa com um menu, cada opção do menu deve ser um exercício do 2 ao 6. Cada opção deve após receber entrada de dados, chamar uma função recursiva e exibir o resultado. O programa deve ser implementado em C# console. Submeta como resposta somente o arquivo Program.cs (não compactar).
string op = "0";
while (op != "9"){
    Console.Clear();
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Exponencial (EX 2)");
    Console.WriteLine("2 - Iterativa (EX 3)");
    Console.WriteLine("3 - Algoritmo de Euclides (EX 4)");
    Console.WriteLine("4 - Fibonacci (EX 5)");
    Console.WriteLine("5 - Converter int -> bin (EX 6)");
    Console.WriteLine("9 - Sair");
    Console.Write("Digite a opção desejada: ");
    op = Console.ReadLine();

    int x, y = 0;

    switch(op){
        case "1":
            Console.Write("Informe a base: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Informe o expoente: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("O exponencial de " + x + " elevado a " + y + " é igual a " + exponencial(x,y) + ".");
            break;
        case "2":
            Console.Write("Serão apresentado todos os números ao cubo de 1 até o número desejado.");
            Console.Write("Informe o número de iterações: ");
            x = int.Parse(Console.ReadLine());
            iterativa(x);
            break;
        case "3":
            break;
        case "4":
            Console.Write("Informe qual o termo da série de Fibonacci você deseja: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("O termo da série de Fibonacci você deseja é igual a " + fibonacci(x) + ".");
            break;
        case "5":
            break;
        default:
            break;
    }

    Console.ReadKey();
}


int exponencial(int numBase, int expoente){
    if(expoente > 1){
        return numBase * exponencial(numBase, expoente-1);
    } else {
        return numBase;
    }

}

void iterativa(int x){
    if(x > 0){
        iterativa(x-1);
        int exp = x * x * x;
        Console.WriteLine($"O número {x} ao cubo é: {exp}.");
    }
}

void euclides(){

}

int fibonacci(int x){
    return 0;
}

void conversor(){

}

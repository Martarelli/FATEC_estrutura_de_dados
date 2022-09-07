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

    switch(op){
        case "1":
            Console.WriteLine("Informe a base: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o expoente: ");
            int y = int.Parse(Console.ReadLine());
            int resultado = exponencial(x,y);
            Console.WriteLine("O exponencial de " + x + " elevado a " + y + " é igual a " + resultado + ".");
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        default:
            break;
    }

    Console.ReadKey();
}


int exponencial(int x, int y){
    if(y > 1){
        return x * exponencial(x, y-1);
    } else {
        return x;
    }

}

void iterativa(){

}

void euclides(){

}

void fibonacci(){

}

void conversor(){

}

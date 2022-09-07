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


    Console.ReadKey();
}

void exponencial(){
    
}

void iterativa(){

}

void euclides(){

}

void fibonacci(){

}

void conversor(){

}

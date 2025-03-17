using System;
class aula16{
    static void Main(){

        string input,operacao;
        inicio:

        Console.Clear();

        Console.WriteLine("CALCULADORA");
        Console.WriteLine("Escolha uma operação: [+]Soma | [-]Subtração | [*]Multiplicação | [/]Divisão");
        
        input = Console.ReadLine();

        switch (input){
            case "+":
            case "Soma":
            case "soma":
                operacao = "Soma";
            break;

            case "-":
            case "Subtração":
            case "subtração":
                operacao = "Subtração";
            break;

            case "*":
            case "Multiplicação":
            case "multiplicação":
                operacao = "Multiplicação";
            break;

            case "/":
            case "Divisão":
            case "divisão":
                operacao = "Divisão";
            break;

            default:
                operacao = "Nenhuma";
            break;

        }

        if (operacao == "Nenhuma"){
            Console.WriteLine("Operação Indisponível");
        }

        else{
            Console.WriteLine("Você escolheu a operação de {0}",operacao);
        }

        Console.WriteLine("Escolher outra operação?[s/n]");
        input = Console.ReadLine();

        if (input == "s" || input == "S"){
            goto inicio;
        }

        else{
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
}
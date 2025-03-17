using System;
class aula15{
    static void Main(){

        string input,operacao;

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
    }
}
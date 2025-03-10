using System;
class aula08{
    static void Main(){
        
        double v1,v2,soma,sub,mult,div;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1 + v2;
        sub = v1 - v2;
        mult = v1 * v2;
        div = v1 / v2;

        Console.WriteLine("A soma de {0} e {1} é igual a {2}", v1,v2,soma);
        Console.WriteLine("A subtração de {0} e {1} é igual a {2}", v1,v2,sub);
        Console.WriteLine("A multiplicação de {0} e {1} é igual a {2}", v1,v2,mult);
        Console.WriteLine("A divisão de {0} e {1} é igual a {2}", v1,v2,div);

    }
}
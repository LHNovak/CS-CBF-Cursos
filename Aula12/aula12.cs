using System;
class aula12{
    static void Main(){

        double n1,n2,n3,nota;
        string res = "reprovado";

        Console.WriteLine("Digite a nota do primeiro Trimestre: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do segundo Trimestre: ");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do terceiro Trimestre: ");
        n3 = double.Parse(Console.ReadLine());

        nota = (n1 + n2 + n3) / 3;

        if(nota >= 60){
            res = "Aprovado";
        }

        Console.WriteLine(" Nota: {1} | Resultado: {0}", res,nota);
    
    }
    
}
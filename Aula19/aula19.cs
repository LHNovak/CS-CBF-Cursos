using System;
class aula19{
    
    static void Main(){

        int[] num = new int[10];

        for(int i=0; i < num.Length; i++){
            num[i] = 0;
            Console.WriteLine("Teste nº "+ i + " Valor de Vetor = " + num[i]);
        }

        Console.WriteLine ("Programa Encerrado.");

    }
}
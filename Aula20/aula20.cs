using System;
class aula20{
    
    static void Main(){

        int[] num = new int[10];
        int i = num.Length - 2;

        while(i>0){
            num[i] = num[i + 1] + 2;
            Console.WriteLine("Loop nº "+ i + " Valor de Vetor = " + num[i]);
            i--;
        }

        Console.WriteLine ("Programa Encerrado.");

    }
}
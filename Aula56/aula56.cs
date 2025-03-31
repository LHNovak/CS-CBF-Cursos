using System;
using System.Collections.Generic;
class Principal{
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");

        LinkedListNode<string> no;
        
        no = transp.FindLast("Navio").Next;
        //no = transp.FindLast("Navio").Value;
        transp.AddAfter(no, "Skate");

        //transp.Clear();
        //transp.Remove("Skate");
        //transp.First();

        if(transp.Find("Moto")==null){
            Console.WriteLine("Não encontrado\n");
        } else{
            Console.WriteLine("Encontrado\n");
        }

        foreach (var item in transp)
        {
            Console.WriteLine(item);
        }
    }
}
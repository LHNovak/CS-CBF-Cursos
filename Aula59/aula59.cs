using System;
using System.Collections.Generic;

class Principal{
    static void Main(){

        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");

        System.Console.WriteLine(veiculos.Peek());
        veiculos.Dequeue();

        Console.WriteLine("Há {0} elementos na fila:\n",veiculos.Count);

        foreach (var item in veiculos)
        {
            Console.WriteLine(item);
        }

        string v= Console.ReadLine();

        if(veiculos.Contains(v)){
            System.Console.WriteLine(v + " Está na fila");
        } else{
            Console.WriteLine(v + " Não está na fila");
        }
    }
}
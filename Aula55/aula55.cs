using System;
using System.Collections.Generic;
class Principal{
    static void Main(){

        Dictionary <int,string> veiculos = new Dictionary<int,string>();

        veiculos.Add(4,"Carro");
        veiculos.Add(8,"Avião");
        veiculos.Add(12,"Navio");
        veiculos.Add(24,"Moto");
        veiculos.Add(16,"Bicicleta");

        int chave = int.Parse(Console.ReadLine());
        string valor = Console.ReadLine();
        Console.Clear();

        //veiculos.Clear();
        //veiculos.Remove(24);
        veiculos[12]="Iate";

        Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);
        
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} está na coleção.",chave);
        }else{
            Console.WriteLine("A chave {0} não foi encontrada.",chave);
        }
        
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("O valor {0} está na coleção.",valor);
        }else{
            Console.WriteLine("O valor {0} não foi encontrado.",valor);
        }

        foreach (var item in veiculos)
        {
            Console.Write(item.Value + " | ");
        }

    }
}
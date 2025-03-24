using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;


    public void info(){
        Console.WriteLine("Marca: {0}",marca);
        Console.WriteLine("Modelo: {0}",modelo);
        Console.WriteLine("Cor: {0}\n",cor);
    }
}

class Principal{
    static void Main(){

        Carro[] c1 = new Carro[2];
        
        c1[0].marca = "Chev";
        c1[0].modelo = "Celta";
        c1[0].cor = "Preto";
        
        c1[1].marca = "Fyord";
        c1[1].modelo = "Delta";
        c1[1].cor = "Branco";

        foreach (var item in c1)
        {
            item.info();            
        }
        
    }
}
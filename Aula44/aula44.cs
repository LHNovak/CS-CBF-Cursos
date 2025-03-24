using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}

class Principal{
    static void Main(){

        Carro c1;

        c1.marca = "Chev";
        c1.modelo = "Celta";
        c1.cor = "Preto";

        Console.WriteLine("Marca: {0}",c1.marca);
        Console.WriteLine("Modelo: {0}",c1.modelo);
        Console.WriteLine("Cor: {0}",c1.cor);

    }
}
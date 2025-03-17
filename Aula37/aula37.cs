using System;

class Base{
    public Base(){
        System.Console.WriteLine("Construtor da Classe Base");
    }
}

class Derivada1:Base{
    public Derivada1() {
        System.Console.WriteLine("Construtor da Classe Derivada1");
    }
}

class Derivada2:Derivada1{
    public Derivada2() {
        System.Console.WriteLine("Construtor da Classe Derivada2");
    }
}

class Principal{
    static void Main(){
        Derivada2 derivada2 = new Derivada2();
    }
}
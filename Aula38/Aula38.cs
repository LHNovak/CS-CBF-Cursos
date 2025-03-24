using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da Classe Base");
    }

    virtual public void info(){}

}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Classe Derivada1");
    }

    override public void info(){
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Classe Derivada2");
    }
    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}

class Principal{
    static void Main(){
        
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        
        Ref = derivada1;
        Ref.info();
    }
}
using System;

class Carro{
    private int velMax;

    public int vm{
        get{
            return velMax;
        }
        set{
           if(value < 0){
            velMax=0;
           } else if(value > 300){
            velMax=300;
           } else {
            velMax=value;
           }
        }
    }
    public Carro(){
        vm = 120;
    }
}

class Principal{
    static void Main(){

        Carro c1 = new Carro();
        c1.vm = 260;

        System.Console.WriteLine("Velocidade: {0}",c1.vm);
    }
}
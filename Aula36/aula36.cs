using System;

class Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }

    public int getVelMax(){
        return velMax;
    }

}    
class Carro : Veiculo{
    public string nome;
    public Carro(string nome, int vm):base(vm){
        this.nome = nome;
        ligado = false;
    }
}

class Principal{
    static void Main(){

        Carro carro= new Carro("Celta",120);

        Console.WriteLine("Nome: {0}",carro.nome);
        Console.WriteLine("Vel.Maxima: {0}",carro.getVelMax());
        Console.WriteLine("Ligado: {0}",carro.getLigado());

    }
}
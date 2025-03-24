using System;

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo,Combate{
    public bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }

    public void setMunicao(int municao){
        this.municao = municao;
    }

    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false;
    }

    public void disparar(){

    }

    public void info(){}
}

class Principal{
    static void Main(){
        Carro carro= new Carro();
    }
}
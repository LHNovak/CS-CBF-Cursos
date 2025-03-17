using System;

class Principal{
    static void Main(){
        
        string nome1,nome2;
        
        System.Console.WriteLine("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();
        System.Console.WriteLine("Digite o nome do jogador 2: ");
        nome2 = Console.ReadLine();
        System.Console.Clear();
        
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador(nome2);
        Jogador j3 = new Jogador("Carlos",50);
        Jogador j4 = new Jogador("Davi",0,false);
        
        j1.info();
        j2.info();
        j3.info();
        j4.info();

    }
    
}

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

     public Jogador(string n, int e){
        energia = e;
        vivo = true;
        nome = n;
    }

     public Jogador(string n, int e, bool v){
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info(){
        Console.WriteLine("Nome Jogador: {0}",nome);
        Console.WriteLine("Energia Jogador: {0}",energia);
        Console.WriteLine("Estado Jogador: {0}\n",vivo);
    }

    ~Jogador(){
        System.Console.WriteLine("Jogador {0} foi removido",nome);
    }

}
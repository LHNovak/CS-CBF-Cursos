using System;

class Principal{
    static void Main(){
        
        string nome1,nome2;
        
        System.Console.WriteLine("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();
        System.Console.WriteLine("Digite o nome do jogador 2: ");
        nome2 = Console.ReadLine();
        
        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador(nome2);

        j1.energia = 50;
        
        Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
    }
    
}

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    ~Jogador(){
        System.Console.WriteLine("Jogador {0} foi removido",nome);
    }

}
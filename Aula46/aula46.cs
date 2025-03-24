using System;

class Galinha{
    private string nome;
    private int ovos;
    public Galinha(string nome){
        this.nome = nome;
        ovos = 0;
    }

    public Ovo botar(){
        ovos++;
        return new Ovo(ovos, nome);
    }
}

class Ovo{
    private int ovos;
    private string nome;
    public Ovo(int ovos, string nome){
        this.ovos = ovos;
        this.nome = nome;
        Console.WriteLine("Ovo Criado:{0} - {1}",this.ovos, this.nome);
    }
}

class Principal{
    static void Main(){

        Galinha g1 = new Galinha("Bennet");
        Galinha g2 = new Galinha("Felicia");
        Galinha g3 = new Galinha("Maria");

        g1.botar();
        g1.botar();
        g2.botar();
        g3.botar();
        g2.botar();
        g1.botar();
        g2.botar();
    }
}
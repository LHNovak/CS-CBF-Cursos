using System;

class Calculo{
    public int soma(params int[] x){
        int s=0;
        foreach (var item in x)
        {
            s+=item;
        }
        /*for(int i=0; i< x.Lenght;i++){
            s+=x[i];
        }*/
        return s;
    }

    public double soma(params double[] x){
        double s=0;
        foreach (var item in x)
        {
            s+=item;
        }
        /*for(int i=0; i<x.Lenght;i++){
            s+=x[i];
        }*/
        return s;
    }
}

class Principal{
    static void Main(){

        Calculo conta = new Calculo();

        var res = conta.soma(4,7,6.5,11.8);

        Console.WriteLine(res);

    }
}

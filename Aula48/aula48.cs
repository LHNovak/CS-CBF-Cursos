using System;

class Calculo{
    public int soma(params int[] x){
        int s=0;
        foreach (var item in x)
        {
            s+=item;
        }
        return s;
    }

    public double soma(params double[] x){
        double s=0;
        foreach (var item in x)
        {
            s+=item;
        }
        return s;
    }

    public int fat(int n){
        int res;
        res = (n<=1) ? 1 : n * fat(n-1);
        return res;
    }
}

class Principal{
    static void Main(){

        Calculo conta = new Calculo();

        var res = conta.soma(4,7,6.5,11.8);
        var fat = conta.fat(5);

        Console.WriteLine(res);
        Console.WriteLine(fat);

    }
}

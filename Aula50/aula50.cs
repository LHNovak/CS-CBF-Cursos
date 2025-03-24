using System;

delegate int Op(params int[] n);

class Mat{
    public static int soma(params int[] n){
        int s=0;
        foreach (var item in n)
        {
            s+=item;
        }
        return s;
    }

    public static int dobro(int n){
        return n*2;
    }

    public static int mult(params int[] n){
        int m=1;
        foreach (var item in n)
        {
            m*=item;
        }
        return m;
    }
}

class Principal{
    static void Main(){
        int res;
        
        Op d1 = new Op(Mat.soma);

        res=d1(10,50);

        System.Console.WriteLine(res);

        d1= new Op(Mat.mult);

        res = d1(4,5);

        System.Console.WriteLine(res);
    }
}
using System;

class Mat{
    public static double pi = 3.14;

    public static int dobro(int n){
        return n*2;
    }
}
class Principal{
    static void Main(){
        double vpi = Mat.pi;
        int num = 20;

        System.Console.WriteLine(vpi);
        System.Console.WriteLine(Mat.dobro(num));
    }
}
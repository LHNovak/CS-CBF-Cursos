using System;

class Aula26{

    static void Main(){
        int d1,div,quoc,rest;
        d1 = 10;
        div = 5;
        quoc = divide(d1,div,out rest);

        Console.WriteLine("{0}/{1}:quociente={2} e resto={3}",d1,div,quoc,rest);
    }
    

    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }

}
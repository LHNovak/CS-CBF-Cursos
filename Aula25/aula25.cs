using System;

class Aula25{

    static void Main(){
        int num=15;
        dobrar(ref num);
        Console.WriteLine(num);
    }
    

    static void dobrar(ref int valor){
        valor*=2;
    }

}
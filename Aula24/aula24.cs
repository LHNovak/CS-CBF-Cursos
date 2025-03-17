using System;

class Aula24{

    static void Main(){
       int n1 = int.Parse(Console.ReadLine());
       int n2 = n1 * 2;
        Console.WriteLine(soma(n1,n2));
    }

    static int soma(int n1, int n2){
        int res = n1 + n2;
        return res;
    }

}
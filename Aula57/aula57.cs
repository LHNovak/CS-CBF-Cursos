using System;
using System.Collections.Generic;
class Principal{
    static void Main(){

        List<string>carros=new List<string>();
        List<string>carros2=new List<string>();
        string[] carros3=new string[6];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argus");

        //carros2.AddRange(carros);

        if(carros.Contains("HRV")){
            System.Console.WriteLine("Carro na Lista");
        }else{
            System.Console.WriteLine("Carro não encontrado");
        }

        carros.CopyTo(carros3,2);

        foreach (var item in carros3)
        {
            Console.WriteLine(item);
        }

        string c="Golf";
        int pos=0;
        pos=carros.IndexOf(c);
        System.Console.WriteLine(c + " Posição " + pos);
        
    }
}
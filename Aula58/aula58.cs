using System;
using System.Collections.Generic;
class Principal{
    static void Main(){

        List<string>carros=new List<string>();
        List<string>carros2=new List<string>();
        string[] carros3=new string[7];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argus");
        carros.Add("Focus");

        //carros2.AddRange(carros);

        if(carros.Contains("HRV")){
            System.Console.WriteLine("Carro na Lista");
        }else{
            System.Console.WriteLine("Carro não encontrado");
        }

        carros.CopyTo(carros3,2);

        carros.Insert(2,"Cruze");

        int posl=carros.LastIndexOf("Focus");

        //carros.Reverse();
        carros.Sort();
        //int tamanho = carros.Count;
        //int cap = carros.Capacity;

        foreach (var item in carros)
        {
            Console.WriteLine(item);
        }

        string c="Golf";
        int pos=0;
        pos=carros.IndexOf(c);
        System.Console.WriteLine(c + " Posição " + pos);
        System.Console.WriteLine("Posição " + posl);
        
    }
}
using System;

class Principal{
    static void Main(string[] args){
        
        Console.WriteLine("Hello World!");

        if (args.Length > 0){
            int i = 0;
            Console.WriteLine("Foram passados {0} argumentos:", args.Length);
            foreach (var item in args)
            {
                Console.WriteLine("Argumento de posição {0}: {1}",i,item);
                i++;
            }
        } else {
            Console.WriteLine("Não foram passados argumentos");
        }
    }
}
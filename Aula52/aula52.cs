using System;
class Program
{
    
    static void Main()
    {
        int n1,n2,res;
        res=n1=n2=0;

        n1=20;
        n2=0;
        
        try{
            res=n1/n2;
            Console.WriteLine("{0} / {1} = {2}",n1,n2,res);
        } catch(Exception e){
            Console.WriteLine("ERRO: Não foi possível realizar a divisão. {0}",e.Message);
            Console.WriteLine("EX:{0}",e.GetType());
        }
        
    }
}

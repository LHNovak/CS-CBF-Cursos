using System;

class Area{
    public static float Quad(float bas, float altura){
        if(bas <= 0 || altura <= 0){
            throw new Exception("Base ou Altura não podem ser igual a 0");
        }
        return bas*altura;
    }
}
class Program
{
    
    static void Main()
    {
        inicio:
        float area=0;
        float x,y;
        x = float.Parse(Console.ReadLine());
        y = float.Parse(Console.ReadLine());
        
        try{
            area = Area.Quad(x, y);
            Console.WriteLine("Area do quad.: {0}",area);
        }catch(Exception e){
            Console.WriteLine("ERRO: Não foi possível calcular a area. {0}",e.Message);
            goto inicio;
        }finally{
            Console.WriteLine("Fim do processo");
        }
        
    }
}

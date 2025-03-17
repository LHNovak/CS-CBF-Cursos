using System;
class aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){

        DiasSemana ds = (DiasSemana)1;
        int dsx = (int)DiasSemana.Sexta;
        
        Console.WriteLine(ds + " " + dsx);
        Console.WriteLine(ds + dsx);
    
    }
    
}
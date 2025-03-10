using System;
class aula06{
    
    static void Main(){

        double ValorCompra = 15.35;
        double ValorVenda;
        double lucro = 0.1;
        string produto = "Hot Dog";

        ValorVenda = ValorCompra+(ValorCompra*lucro);

        Console.WriteLine("Produto.......:{0,15}",produto);
        Console.WriteLine("Val.compra....:{0,15:c}",ValorCompra);
        Console.WriteLine("Lucro.........:{0,15:p}",lucro);
        Console.WriteLine("Val.Venda.....:{0,15:c}",ValorVenda);

    }
}
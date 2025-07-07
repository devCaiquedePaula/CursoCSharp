using System;

class  Aula06_SaidaNoConsole
{
    static void Main(string[] args)
    {
        int n1, n2, n3;
        
        n1 = 10;
        n2 = 20;
        n3 = 30;

        // Caracteres de formatação e especificação de saída
        Console.WriteLine("n1 = \t{0} \nn2 = \t{1} \nn3 = \t{2}", n1, n2, n3);
        
        string produto = "Notebook";
        double preco = 1999.99;
        int quantidade = 5;

        Console.WriteLine("--------------------");
        Console.WriteLine("Produto: {0}, Preço: {1:c}, Quantidade: {2}", produto, preco, quantidade);
        Console.WriteLine("--------------------");
        
        double valorCompra = 19.99;
        double valorVenda;
        double lucro = 0.2;
        string item = "HotWheels";
        
        valorVenda = valorCompra * (1 + lucro);

        Console.WriteLine("Produto.......:{0,15}", item);
        Console.WriteLine("Val.Compra....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro.........:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda.....:{0,15:c}", valorVenda);
    }
}

using System;

class Aula05{
    static void Main(){
        int n1=10,n2=20,n3=30;
        Console.WriteLine("Exibindo variávis com indices = 'n1={0}',\\nn1");
        Console.WriteLine("n1= {0} \nn2= {1} \nn3= {2}", n1,n2,n3);

        Console.WriteLine("------------------------------------------------");

        double valorCompra = 5.50;
        double valorVenda;
        string produto ="Pastel";
        const double  lucro=0.1;
        
        valorVenda = valorCompra + (valorCompra*lucro);

        Console.WriteLine("Produto.............:{0,15}", produto);
        Console.WriteLine("Val. Compra.........:{0,15:c}", valorCompra);
        Console.WriteLine("Produto.............:{0,15:p}", lucro);
        Console.WriteLine("Val Venda...........:{0,15:c}",valorVenda); 

    }
}
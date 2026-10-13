using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco("123 Main St", "Salt Lake City", "UT", "EUA");
        Cliente cliente1 = new Cliente("Alice Johnson", endereco1);
        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(new Produto("Teclado Mecânico", "T101", 45.50m, 1));
        pedido1.AdicionarProduto(new Produto("Mouse Gamer", "M202", 25.00m, 2));

        Endereco endereco2 = new Endereco("Av. Paulista, 1000", "São Paulo", "SP", "Brasil");
        Cliente cliente2 = new Cliente("Carlos Silva", endereco2);
        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(new Produto("Monitor Ultrawide", "MON500", 300.00m, 1));
        pedido2.AdicionarProduto(new Produto("Cabo HDMI 2m", "CBL02", 15.00m, 3));
        pedido2.AdicionarProduto(new Produto("Suporte para Notebook", "SUP12", 40.00m, 1));

        List<Pedido> pedidos = new List<Pedido> { pedido1, pedido2 };

        int contador = 1;
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"==========================================");
            Console.WriteLine($"PEDIDO #{contador}");
            Console.WriteLine($"==========================================");
            
            Console.WriteLine(pedido.ObterEtiquetaEmbalagem());
            
            Console.WriteLine(pedido.ObterEtiquetaEnvio());
            
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Custo Total do Pedido: ${pedido.CalcularCustoTotal():F2}");
            Console.WriteLine($"==========================================\n");
            
            contador++;
        }
    }
}
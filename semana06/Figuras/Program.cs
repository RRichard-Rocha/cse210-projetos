using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>();

        figuras.Add(new Quadrado("Vermelho", 4.0));
        figuras.Add(new Retangulo("Azul", 5.0, 3.0));
        figuras.Add(new Circulo("Verde", 2.5));

        Console.WriteLine("=== Demonstração de Polimorfismo com Figuras ===");
        
        foreach (Figura figura in figuras)
        {
            string cor = figura.ObterCor();
            double area = figura.ObterArea();

            Console.WriteLine($"Figura de cor {cor} | Área: {area:F2}");
        }
    }
}
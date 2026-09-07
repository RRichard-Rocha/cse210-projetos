using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o número mágico? ");
        string entradaUser = Console.ReadLine();
        int numMagico = int.Parse(entradaUser);
        Console.Write("Qual é o seu palpite? ");
        string palpiteUser = Console.ReadLine();
        int palpite = int.Parse(palpiteUser);

        if (palpite == numMagico)
        {
            Console.WriteLine("Você Adivinhou");            
        }
        else if (palpite < numMagico)
        {
            Console.WriteLine("Mais Alto");
        }
        else if ( palpite > numMagico)
        {
            Console.WriteLine("Mais Baixo");
        }
    }
}
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Random numAleatorio = new Random();
        int numMagico = numAleatorio.Next(1,101);

        int palpite = -1;

        while (palpite != numMagico)
        {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());
            
            if (palpite < numMagico)
            {
            Console.WriteLine("Mais Alto");
            }
            else if ( palpite > numMagico)
            {
            Console.WriteLine("Mais Baixo");
            }
            else
            {
                Console.WriteLine("Voce adivinhou!");
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a sua nota(Numérica)? ");
        string notaDigitada = Console.ReadLine();
        int nota = int.Parse(notaDigitada);
        string letra = "";
        if (nota >= 90)
        {
            letra = "A";
            
        }
        else if (nota >= 80)
        {
            letra = "B";
            
        }
        else if (nota >= 70)
        {
            letra = "C";
            
        }
        else if (nota >= 60)
        {
            letra = "D";
               
        }
        else
        {
            letra = "F";
                
        }
        Console.WriteLine($"Sua nota é {letra}");

        if (nota >= 70)
        {
            Console.WriteLine("Parbéns Voce foi aprovado");
        }
        else
        {
            Console.WriteLine("Estude Mais Para Na Proxima Vez");
        }
    }
}
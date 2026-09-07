using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int numeroUser = -1;
        while (numeroUser != 0)
        {
            Console.Write("Insira uma lista de números e digite 0 quando terminar" );
            string numeroDigitado = Console.ReadLine();
            numeroUser = int.Parse(numeroDigitado);

            if (numeroUser != 0)
            {
            numeros.Add(numeroUser);
            }

        }int soma = 0;
        foreach(int numero in numeros)
        {
            soma += numero;
        }
        Console.WriteLine($"A soma é: {soma}");
        float media = ((float)soma) / numeros.Count;
        Console.WriteLine($"A Média é: {media}");
        int maiorNum = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > maiorNum)
            {
                maiorNum = numero;
            }
            
        }
        Console.WriteLine($"O maior valor é: {maiorNum}");
    }
}
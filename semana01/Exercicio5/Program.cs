using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();
        string nomeUsuario = NomeDeUsuario();
        int numeroUsuario = NumeroFavorito();
        int quadradoUsuario = QuadradoNumero(numeroUsuario);
        ExibirResultado(nomeUsuario, quadradoUsuario);

        static void ExibirBoasVindas()
        {
            Console.WriteLine("Bem-vindo ao programa!");
        }
        static string NomeDeUsuario()
        {
            Console.Write("Por favor, insira seu nome: ");
            string entradaUser = Console.ReadLine();
            return entradaUser;
        }
        static int NumeroFavorito()
        {
            Console.Write("Por favor, insira seu número favorito:" );
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        static int QuadradoNumero(int numero)
        {
            int quadrado = numero * numero;
            return quadrado;
        }
        static void ExibirResultado(string nome, int quadrado)
        {
            Console.WriteLine($"{nome}, o quadrado do seu número favorito é {quadrado}");
        }
    
    }
}
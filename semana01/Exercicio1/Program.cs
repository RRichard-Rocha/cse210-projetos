using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu Nome? ");
        string nome = Console.ReadLine();
        Console.Write("Qual é o seu Sobrenome? ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome é {sobrenome}, {nome} {sobrenome}");
    }
}
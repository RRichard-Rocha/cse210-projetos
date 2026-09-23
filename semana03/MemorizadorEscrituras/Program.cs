using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Proverbios", 3, 5, 6);

        string textoVersiculo = "Confia no Senhor de todo o teu coracao e nao te estribes no teu proprio entendimento";
        Escritura escritura = new Escritura(referencia, textoVersiculo);

        string resposta = "";

        while (resposta.ToLower() != "sair")
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();

            if (escritura.EstaCompletamenteEscondida())
            {
                Console.WriteLine("Parabéns! Você memorizou a escritura!");
                break;
            }

            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar:");
            resposta = Console.ReadLine();

            if (resposta.ToLower() != "sair")
            {
                escritura.EsconderPalavrasAleatorias(3);
            }
        }

        Console.WriteLine("\nPrograma encerrado. Até a próxima!");
    }
}
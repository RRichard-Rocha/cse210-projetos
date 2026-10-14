using System;
using System.Collections.Generic;
using System.Threading;

public class AtividadeDeListagem : Atividade
{
    private List<string> _perguntas;

    public AtividadeDeListagem() : base("Listagem", "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
    {
        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    public void Executar()
    {
        ExecutarMensagemInicial();

        Random rand = new Random();
        string perguntaAleatoria = _perguntas[rand.Next(_perguntas.Count)];

        Console.Clear();
        Console.WriteLine("Liste tantas respostas quanto puder para a seguinte pergunta:");
        Console.WriteLine($"\n--- {perguntaAleatoria} ---\n");
        Console.Write("Você começará em: ");
        MostrarContagemRegressiva(5);
        Console.WriteLine();

        List<string> itens = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duracao);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string resposta = Console.ReadLine();
            if (!string.IsNullOrEmpty(resposta))
            {
                itens.Add(resposta);
            }
        }

        Console.WriteLine($"\nVocê listou {itens.Count} itens!");
        ExecutarMensagemFinal();
    }
}
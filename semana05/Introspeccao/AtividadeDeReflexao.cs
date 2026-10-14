using System;
using System.Collections.Generic;
using System.Threading;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao() : base("Reflexão", "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.")
    {
        _reflexoes = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim trước?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?",
            "Como você pode manter essa experiência em mente no futuro?"
        };
    }

    public void Executar()
    {
        ExecutarMensagemInicial();

        Random rand = new Random();
        string reflexaoAleatoria = _reflexoes[rand.Next(_reflexoes.Count)];

        Console.Clear();
        Console.WriteLine("Considere o seguinte:");
        Console.WriteLine($"\n--- {reflexaoAleatoria} ---\n");
        Console.WriteLine("Quando tiver isso em mente, pressione Enter para continuar.");
        Console.ReadLine();

        Console.WriteLine("Agora, pondere sobre cada uma das seguintes perguntas relacionadas a esta experiência:");
        Console.Write("Você começará em: ");
        MostrarContagemRegressiva(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duracao);

        while (DateTime.Now < endTime)
        {
            string perguntaAleatoria = _perguntas[rand.Next(_perguntas.Count)];
            Console.Write($"\n> {perguntaAleatoria} ");
            MostrarSpinner(5);
        }

        ExecutarMensagemFinal();
    }
}
using System;
using System.Threading;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao() : base("Respiração", "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
    {
    }

    public void Executar()
    {
        ExecutarMensagemInicial();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duracao);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nInspire... ");
            MostrarContagemRegressiva(4);
            
            if (DateTime.Now >= endTime) break;

            Console.Write("\nExpire... ");
            MostrarContagemRegressiva(6);
            Console.WriteLine();
        }

        ExecutarMensagemFinal();
    }
}
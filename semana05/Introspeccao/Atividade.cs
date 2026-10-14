using System;
using System.Collections.Generic;
using System.Threading;

public class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
    }

    public void ExecutarMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à Atividade de {_nome}.\n");
        Console.WriteLine($"{_descricao}\n");
        Console.Write("Quanto tempo, em segundos, você deseja para sua sessão? ");
        
        if (int.TryParse(Console.ReadLine(), out int segundos))
        {
            _duracao = segundos;
        }
        else
        {
            _duracao = 30;
        }

        Console.Clear();
        Console.WriteLine("Prepare-se...");
        MostrarSpinner(3);
    }

    public void ExecutarMensagemFinal()
    {
        Console.WriteLine("\nBom trabalho!!");
        MostrarSpinner(3);
        Console.WriteLine($"\nVocê concluiu a atividade de {_nome} por {_duracao} segundos.");
        MostrarSpinner(3);
    }

    public void MostrarSpinner(int segundos)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(segundos);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Count;
        }
    }

    public void MostrarContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
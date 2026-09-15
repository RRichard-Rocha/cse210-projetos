using System;
using System.Collections.Generic;

public class Diario
{
    public List<Entrada> _listaEntradas = new List<Entrada>();
    public List<string> _listaPerguntas = new List<string>();

    public Diario()
    {
        _listaPerguntas.Add("Quem foi a pessoa mais interessante com quem interagi hoje? ");
        _listaPerguntas.Add("Qual foi a melhor parte do meu dia?");
        _listaPerguntas.Add("Como vi a mão do Senhor em minha vida hoje?");
        _listaPerguntas.Add("Qual foi a emoção mais forte que senti hoje?");
        _listaPerguntas.Add("Se eu pudesse fazer uma coisa hoje, o que seria?");
    
    }
    public void AdicionarEntrada()
    {
        Random randomizador = new Random();
        int indice = randomizador.Next(_listaPerguntas.Count);
        Console.WriteLine($"{_listaPerguntas[indice]}");
        string resposta = Console.ReadLine();
        string data = DateTime.Now.ToShortDateString();

        Entrada novaEntrada = new Entrada();
        novaEntrada._pergunta = _listaPerguntas[indice];
        novaEntrada._resposta = resposta;
        novaEntrada._data = data;
        _listaEntradas.Add(novaEntrada);
    }
    public void ExibirDiario()
    {
        foreach (Entrada entrada in _listaEntradas)
        {
            entrada.Exibir();
        }
    }
    public void SalvarEmArquivo()
    {
        Console.Write("Qual é o Nome do Arquivo? ");
        string nomeArquivo = Console.ReadLine();
        using (StreamWriter arquivoSaida = new StreamWriter(nomeArquivo))
        {
            foreach (Entrada entrada in _listaEntradas)
            {
                arquivoSaida.WriteLine($"{entrada._data}|{entrada._pergunta}|{entrada._resposta}");
            }
        }
    }
    public void CarregarArquivo()
    {
        Console.Write("Qual é o Nome do Arquivo que Deseja Carregar? ");
        string nomeArquivo = Console.ReadLine();
        string[] linhas = File.ReadAllLines(nomeArquivo);
        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');
            Entrada novaEntrada = new Entrada();
            novaEntrada._data = partes[0];
            novaEntrada._pergunta = partes[1];
            novaEntrada._resposta = partes[2];
            _listaEntradas.Add(novaEntrada);
        }
        Console.WriteLine("Diário carregado com sucesso!");
    }
}
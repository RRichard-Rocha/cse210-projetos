using System;

public class Entrada
{
    public string _pergunta;
    public string _resposta;
    public string _data;
    public void Exibir()
    {
        Console.WriteLine($"data: {_data}, {_pergunta} Resposta: {_resposta}");
    }
}

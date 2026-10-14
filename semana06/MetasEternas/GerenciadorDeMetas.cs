using System;
using System.Collections.Generic;

public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos;

    public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    public void Iniciar()
    {
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"Você tem {_pontos} pontos.");
    }

    public void ListarNomesDasMetas()
    {
    }

    public void ListarDetalhesDasMetas()
    {
    }

    public void CriarMeta()
    {
    }

    public void RegistrarEvento()
    {
    }

    public void SalvarMetas()
    {
    }

    public void CarregarMetas()
    {
    }
}
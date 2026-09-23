using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string textoEscritura)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] pedacos = textoEscritura.Split(' ');

        foreach (string pedaco in pedacos)
        {
            Palavra palavraObj = new Palavra(pedaco);
            _palavras.Add(palavraObj);
        }

    }

    public void EsconderPalavrasAleatorias(int numeroParaEsconder)
    {
        Random random = new Random();

        int escondidas = 0;

        while (escondidas < numeroParaEsconder && !EstaCompletamenteEscondida())
        {
            int indiceAleatorio = random.Next(_palavras.Count);

            Palavra palavraSorteada = _palavras[indiceAleatorio];

            if (!palavraSorteada.EstaEscondida())
            {
                palavraSorteada.Esconder();
                escondidas++;
            }
        }
    }

    public string ObterTexto()
    {
        string textoFinal = _referencia.ObterTexto() + " ";

        foreach (Palavra palavra in _palavras)
        {
            textoFinal += palavra.ObterTexto() + " ";

        }
        return textoFinal.Trim();
    }

    public bool EstaCompletamenteEscondida()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaEscondida())
            {
                return false;
            }
        }

        return true;
    }
}
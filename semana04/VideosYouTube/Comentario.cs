using System;

public class Comentario
{
    private string _nomeAutor;
    private string _textoComentario;

    public Comentario(string nomeAutor, string textoComentario)
    {
        _nomeAutor = nomeAutor;
        _textoComentario = textoComentario;
    }

    public string ObterNomeAutor()
    {
        return _nomeAutor;
    }

    public string ObterTextoComentario()
    {
        return _textoComentario;
    }
}
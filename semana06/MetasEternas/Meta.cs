using System;

public abstract class Meta
{
    protected string _nome;
    protected string _descricao;
    protected int _pontos;

    public Meta(string nome, string descricao, int pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public abstract void RegistrarEvento();
    public abstract bool EstaConcluida();

    public virtual string ObterDetalhesEmTexto()
    {
        string status = EstaConcluida() ? "[X]" : "[ ]";
        return $"{status} {_nome} ({_descricao})";
    }

    public abstract string ObterRepresentacaoEmTexto();
}
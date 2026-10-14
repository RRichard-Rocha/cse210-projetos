public class MetaDeListaDeTarefas : Meta
{
    private int _concluidas;
    private int _total;
    private int _bonus;

    public MetaDeListaDeTarefas(string nome, string descricao, int pontos, int total, int bonus) 
        : base(nome, descricao, pontos)
    {
        _concluidas = 0;
        _total = total;
        _bonus = bonus;
    }

    public override void RegistrarEvento()
    {
        _concluidas++;
    }

    public override bool EstaConcluida()
    {
        return _concluidas >= _total;
    }

    public override string ObterDetalhesEmTexto()
    {
        string status = EstaConcluida() ? "[X]" : "[ ]";
        return $"{status} {_nome} ({_descricao}) -- Atualmente completado: {_concluidas}/{_total}";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas:{_nome},{_descricao},{_pontos},{_bonus},{_total},{_concluidas}";
    }
}
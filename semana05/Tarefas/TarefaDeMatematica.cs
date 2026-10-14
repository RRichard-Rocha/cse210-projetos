public class TarefaDeMatematica : Tarefa
{
    private string _secaoDoCapitulo;
    private string _problemas;

    public TarefaDeMatematica(string nomeEstudante, string topico, string secaoDoCapitulo, string problemas)
        : base(nomeEstudante, topico)
    {
        _secaoDoCapitulo = secaoDoCapitulo;
        _problemas = problemas;
    }

    public string ObterListaDeTarefas()
    {
        return $"Capítulo {_secaoDoCapitulo} Problemas {_problemas}";
    }
}
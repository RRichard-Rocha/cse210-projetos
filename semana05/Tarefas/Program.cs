using System;

class Program
{
    static void Main(string[] args)
    {
        // Teste 1: Tarefa simples da classe base
        Tarefa t1 = new Tarefa("Samuel Silva", "Multiplicação");
        Console.WriteLine(t1.ObterResumo());
        Console.WriteLine();

        // Teste 2: Tarefa de Matemática
        TarefaDeMatematica t2 = new TarefaDeMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(t2.ObterResumo());
        Console.WriteLine(t2.ObterListaDeTarefas());
        Console.WriteLine();

        // Teste 3: Tarefa de Redação
        TarefaDeRedacao t3 = new TarefaDeRedacao("Maria Antunes", "História da Europa", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(t3.ObterResumo());
        Console.WriteLine(t3.ObterInformacoesDaRedacao());
    }
}
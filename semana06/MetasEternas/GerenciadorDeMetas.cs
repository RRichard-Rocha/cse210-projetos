using System;
using System.Collections.Generic;
using System.IO;

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
        int escolha = 0;

        while (escolha != 6)
        {
            Console.WriteLine();
            ExibirInfoJogador();
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("  1. Criar Nova Meta");
            Console.WriteLine("  2. Listar Metas");
            Console.WriteLine("  3. Salvar Metas");
            Console.WriteLine("  4. Carregar Metas");
            Console.WriteLine("  5. Registrar Evento");
            Console.WriteLine("  6. Sair");
            Console.Write("Selecione uma opção da escolha: ");

            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        CriarMeta();
                        break;
                    case 2:
                        ListarDetalhesDasMetas();
                        break;
                    case 3:
                        SalvarMetas();
                        break;
                    case 4:
                        CarregarMetas();
                        break;
                    case 5:
                        RegistrarEvento();
                        break;
                    case 6:
                        Console.WriteLine("Até logo! Continue firme em suas metas.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"Você tem {_pontos} pontos.");
    }

    public void ListarNomesDasMetas()
    {
        Console.WriteLine("\nAs metas são:");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_metas[i].ObterDetalhesEmTexto().Split(' ')[1]}");
        }
    }

    public void ListarDetalhesDasMetas()
    {
        Console.WriteLine("\nAs metas são:");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void CriarMeta()
    {
        Console.WriteLine("\nTipos de Meta:");
        Console.WriteLine("  1. Meta Simples");
        Console.WriteLine("  2. Meta Eterna");
        Console.WriteLine("  3. Meta de Lista de Tarefas");
        Console.Write("Qual tipo de meta você gostaria de criar? ");

        if (int.TryParse(Console.ReadLine(), out int tipo))
        {
            Console.Write("Qual é o nome da sua meta? ");
            string nome = Console.ReadLine();

            Console.Write("Escreva uma breve descrição dela: ");
            string descricao = Console.ReadLine();

            Console.Write("Quantos pontos esta meta vale? ");
            int.TryParse(Console.ReadLine(), out int pontos);

            switch (tipo)
            {
                case 1:
                    _metas.Add(new MetaSimples(nome, descricao, pontos));
                    break;
                case 2:
                    _metas.Add(new MetaEterna(nome, descricao, pontos));
                    break;
                case 3:
                    Console.Write("Quantas vezes esta meta precisa ser realizada para ser concluída? ");
                    int.TryParse(Console.ReadLine(), out int total);

                    Console.Write("Qual é o bônus por concluí-la tantas vezes? ");
                    int.TryParse(Console.ReadLine(), out int bonus);

                    _metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus));
                    break;
                default:
                    Console.WriteLine("Tipo inválido.");
                    break;
            }
        }
    }

    public void RegistrarEvento()
    {
        if (_metas.Count == 0)
        {
            Console.WriteLine("Não há metas cadastradas ainda.");
            return;
        }

        Console.WriteLine("\nMetas disponíveis:");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }

        Console.Write("Qual meta você realizou? ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= _metas.Count)
        {
            Meta metaSelecionada = _metas[indice - 1];
            metaSelecionada.RegistrarEvento();
            Console.WriteLine("Parabéns! Evento registrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Seleção inválida.");
        }
    }

    public void SalvarMetas()
    {
        Console.Write("Qual é o nome do arquivo para salvar as metas? ");
        string nomeArquivo = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(nomeArquivo))
        {
            outputFile.WriteLine(_pontos);
            foreach (Meta meta in _metas)
            {
                outputFile.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }
        Console.WriteLine("Metas salvas com sucesso!");
    }

    public void CarregarMetas()
    {
        Console.Write("Qual é o nome do arquivo com as metas? ");
        string nomeArquivo = Console.ReadLine();

        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            _pontos = int.Parse(linhas[0]);
            _metas.Clear();

            for (int i = 1; i < linhas.Length; i++)
            {
                string linha = linhas[i];
                string[] partes = linha.Split(":");
                string tipoMeta = partes[0];
                string detalhes = partes[1];
                string[] dados = detalhes.Split(",");

                if (tipoMeta == "MetaSimples")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    bool estaConcluida = bool.Parse(dados[3]);

                    MetaSimples meta = new MetaSimples(nome, descricao, pontos);
                    if (estaConcluida) meta.RegistrarEvento();
                    _metas.Add(meta);
                }
                else if (tipoMeta == "MetaEterna")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    _metas.Add(new MetaEterna(nome, descricao, pontos));
                }
                else if (tipoMeta == "MetaDeListaDeTarefas")
                {
                    string nome = dados[0];
                    string descricao = dados[1];
                    int pontos = int.Parse(dados[2]);
                    int bonus = int.Parse(dados[3]);
                    int total = int.Parse(dados[4]);
                    int concluidas = int.Parse(dados[5]);

                    MetaDeListaDeTarefas meta = new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus);
                    for (int c = 0; c < concluidas; c++)
                    {
                        meta.RegistrarEvento();
                    }
                    _metas.Add(meta);
                }
            }
            Console.WriteLine("Metas carregadas com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}
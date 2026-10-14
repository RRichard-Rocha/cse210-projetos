using System;

class Program
{
    static void Main(string[] args)
    {
        int escolha = 0;

        while (escolha != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("  1. Iniciar atividade de respiração");
            Console.WriteLine("  2. Iniciar atividade de reflexão");
            Console.WriteLine("  3. Iniciar atividade de listagem");
            Console.WriteLine("  4. Sair");
            Console.Write("Selecione uma opção: ");

            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
                        respiracao.Executar();
                        break;
                    case 2:
                        AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                        reflexao.Executar();
                        break;
                    case 3:
                        AtividadeDeListagem listagem = new AtividadeDeListagem();
                        listagem.Executar();
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa. Até logo!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido. Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
        }
    }
}
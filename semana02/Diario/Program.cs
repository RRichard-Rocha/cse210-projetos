using System;

class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        string escolha = "";
        while (escolha != "5")
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Escrever nova entrada");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Salvar o diário em arquivo");
            Console.WriteLine("4. Carregar o diário de um arquivo");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            
            escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                meuDiario.AdicionarEntrada();
                break;
                case "2":
                meuDiario.ExibirDiario();
                break;
                case "3":
                meuDiario.SalvarEmArquivo();
                break;
                case "4":
                meuDiario.CarregarArquivo();
                break;
                case "5":
                Console.WriteLine("Encerrando o Diário");
                break;
                default:
                Console.WriteLine("Opção Inválida! Escolha um número entre 1 e 5");
                break;
            }
        }
    }
}
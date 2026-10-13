using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public decimal CalcularCustoTotal()
    {
        decimal custoProdutos = 0;

        foreach (var produto in _produtos)
        {
            custoProdutos += produto.CalcularCustoTotal();
        }

        decimal custoEnvio = _cliente.MoraNosEUA() ? 5.0m : 35.0m;

        return custoProdutos + custoEnvio;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- Etiqueta de Embalagem ---");
        foreach (var produto in _produtos)
        {
            sb.AppendLine($"Produto: {produto.ObterNome()} | ID: {produto.ObterIdProduto()}");
        }
        return sb.ToString();
    }

    public string ObterEtiquetaEnvio()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- Etiqueta de Envio ---");
        sb.AppendLine($"Cliente: {_cliente.ObterNome()}");
        sb.AppendLine("Endereço:");
        sb.AppendLine(_cliente.ObterEndereco().ObterEnderecoCompleto());
        return sb.ToString();
    }
}
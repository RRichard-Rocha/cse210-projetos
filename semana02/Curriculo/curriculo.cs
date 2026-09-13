using System;
public class Curriculo
{
    public string _nome;
    public List<Emprego> _empregos = new List<Emprego>();
    
    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        foreach (Emprego e in _empregos)
        {
            e.Exibir();
        }
    }
}
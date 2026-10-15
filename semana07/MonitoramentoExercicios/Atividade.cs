using System;

public abstract class Atividade
{
    private string _data;
    private int _minutos;

    public Atividade(string data, int minutos)
    {
        _data = data;
        _minutos = minutos;
    }

    public string ObterData()
    {
        return _data;
    }

    public int ObterMinutos()
    {
        return _minutos;
    }

    public virtual double ObterDistancia()
    {
        return 0.0;
    }

    public virtual double ObterVelocidade()
    {
        return 0.0;
    }

    public virtual double ObterRitmo()
    {
        return 0.0;
    }

    public virtual string ObterResumo()
    {
        string nomeAtividade = this.GetType().Name.Replace("Atividade", "");
        
        return $"{_data} {nomeAtividade} ({_minutos} min): " +
               $"Distância {ObterDistancia():0.0} km, " +
               $"Velocidade: {ObterVelocidade():0.0} km/h, " +
               $"Ritmo: {ObterRitmo():0.00} min por km";
    }
}
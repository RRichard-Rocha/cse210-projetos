public class Ciclismo : Atividade
{
    private double _velocidadeKmH;

    public Ciclismo(string data, int minutos, double velocidadeKmH) : base(data, minutos)
    {
        _velocidadeKmH = velocidadeKmH;
    }

    public override double ObterVelocidade()
    {
        return _velocidadeKmH;
    }

    public override double ObterDistancia()
    {
        return (_velocidadeKmH * ObterMinutos()) / 60;
    }

    public override double ObterRitmo()
    {
        return 60 / _velocidadeKmH;
    }
}
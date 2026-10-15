public class Corrida : Atividade
{
    private double _distanciaKm;

    public Corrida(string data, int minutos, double distanciaKm) : base(data, minutos)
    {
        _distanciaKm = distanciaKm;
    }

    public override double ObterDistancia()
    {
        return _distanciaKm;
    }

    public override double ObterVelocidade()
    {
        return (_distanciaKm / ObterMinutos()) * 60;
    }

    public override double ObterRitmo()
    {
        return ObterMinutos() / _distanciaKm;
    }
}
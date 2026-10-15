using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Atividade> atividades = new List<Atividade>();

        atividades.Add(new Corrida("03 Nov 2022", 30, 4.8));
        atividades.Add(new Ciclismo("04 Nov 2022", 45, 20.0));
        atividades.Add(new Natacao("05 Nov 2022", 40, 20)); // 20 voltas = 1.0 km

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}
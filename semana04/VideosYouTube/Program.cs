using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Dominando C# em 10 Minutos", "Tech Academy", 620);
        video1.AdicionarComentario(new Comentario("Carlos Silva", "Excelente vídeo, muito explicativo!"));
        video1.AdicionarComentario(new Comentario("Ana Souza", "Me ajudou muito com o conceito de classes."));
        video1.AdicionarComentario(new Comentario("Marcos Lima", "Parabéns pelo conteúdo de qualidade."));
        videos.Add(video1);

        Video video2 = new Video("Introdução à Programação Orientada a Objetos", "CodeMaster", 950);
        video2.AdicionarComentario(new Comentario("Beatriz Costa", "Finalmente entendi o que é encapsulamento e abstração."));
        video2.AdicionarComentario(new Comentario("João Pedro", "Áudio ótimo e didática impecável."));
        video2.AdicionarComentario(new Comentario("Lucas Mendes", "Muito bom! Aguardando a parte 2."));
        videos.Add(video2);

        Video video3 = new Video("Como usar Listas e Foreach em C#", "DevPro", 480);
        video3.AdicionarComentario(new Comentario("Mariana Rocha", "Salvou meu trabalho da faculdade, obrigada!"));
        video3.AdicionarComentario(new Comentario("Gabriel Santos", "Explicação direta ao ponto, adorei."));
        video3.AdicionarComentario(new Comentario("Fernanda Dias", "Muito claro e objetivo."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"==================================================");
            Console.WriteLine($"Título: {video.ObterTitulo()}");
            Console.WriteLine($"Autor: {video.ObterAutor()}");
            Console.WriteLine($"Duração: {video.ObterDuracao()} segundos");
            Console.WriteLine($"Número de Comentários: {video.ObterNumeroComentarios()}");
            Console.WriteLine($"--------------------------------------------------");
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine($"- {comentario.ObterNomeAutor()}: \"{comentario.ObterTextoComentario()}\"");
            }
            Console.WriteLine();
        }
    }
}
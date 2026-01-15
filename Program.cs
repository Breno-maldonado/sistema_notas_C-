using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"
█▀ █ █▀ ▀█▀ █▀▀ █▀▄▀█ ▄▀█   █▀▄ █▀▀   █▄░█ █▀█ ▀█▀ ▄▀█ █▀
▄█ █ ▄█ ░█░ ██▄ █░▀░█ █▀█   █▄▀ ██▄   █░▀█ █▄█ ░█░ █▀█ ▄█");
        Console.WriteLine();
        string nome = LerNome();
        int nota1 = LerNota("Digite a primeira nota: ");
        int nota2 = LerNota("Digite a segunda nota: ");
        int nota3 = LerNota("Digite a terceira nota: ");

        double media = (nota1 + nota2 + nota3) / 3.0;
        string status = ObterStatus(media);

        Console.Clear();
        Console.WriteLine(@"
█▀ █ █▀ ▀█▀ █▀▀ █▀▄▀█ ▄▀█   █▀▄ █▀▀   █▄░█ █▀█ ▀█▀ ▄▀█ █▀
▄█ █ ▄█ ░█░ ██▄ █░▀░█ █▀█   █▄▀ ██▄   █░▀█ █▄█ ░█░ █▀█ ▄█");
        Console.WriteLine();
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Nota 1: {nota1}");
        Console.WriteLine($"Nota 2: {nota2}");
        Console.WriteLine($"Nota 3: {nota3}");
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Status: {status}");
    }

    static string LerNome()
    {
        string nome;

        while (true)
        {
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nome) && nome.All(char.IsLetter))
                return nome;

            Console.WriteLine("Erro: O nome deve conter apenas letras.");
        }
    }

    static int LerNota(string mensagem)
    {
        int nota;

        while (true)
        {
            Console.Write(mensagem);

            if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                return nota;

            Console.WriteLine("Erro: Digite uma nota válida entre 0 e 10.");
        }
    }

    static string ObterStatus(double media)
    {
        if (media >= 7)
            return "Aprovado";
        else if (media >= 5)
            return "Recuperação";
        else
            return "Reprovado";
    }
}

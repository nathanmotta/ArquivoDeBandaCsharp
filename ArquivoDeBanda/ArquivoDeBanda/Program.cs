using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string banda, instrumentos;
        int discos, shows, musicas;

        Console.WriteLine("Digite o nome da banda: ");
        banda = Console.ReadLine();

        Console.WriteLine("Quais instrumentos a banda possui? ");
        instrumentos = Console.ReadLine();

        Console.WriteLine("Quantos discos a banda já gravou? ");
        discos = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantos shows a banda já fez?");
        shows = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantas musicas a banda tem? ");
        musicas = int.Parse(Console.ReadLine());

        Console.WriteLine("Conclusao: ");

        Console.WriteLine("Nome da banda: " + banda);
        Console.WriteLine("Instrumentos: " + instrumentos);
        Console.WriteLine("Discos lancados: " + discos);
        Console.WriteLine("Quantidade de shows: " + shows);
        Console.WriteLine("Quantidade de musicas: " + musicas);
    }
}
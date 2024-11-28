class Greeting
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");

        var username = Console.ReadLine();

        Console.WriteLine("Digite uma frase de boas vindas: ");

        var greeting = Console.ReadLine();

        Console.WriteLine($"{greeting} {username}");

    }
}
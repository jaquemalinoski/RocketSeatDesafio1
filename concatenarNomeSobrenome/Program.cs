class Concat
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");

        var firstName = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");

        var lastName = Console.ReadLine();

        var fullName = string.Concat(firstName, " ", lastName);

        Console.WriteLine(fullName);

    }
}
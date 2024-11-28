class CountCaracters
{
    static void Main( string[] args )
    {
        Console.WriteLine("Digite uma palavra ou frase: ");

        var text = Console.ReadLine();

        int total = text.Length;

        Console.WriteLine($"A frase tem o total de {total} caracteres.");

    }
}
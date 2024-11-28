class Date
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        Console.WriteLine(date);
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("HH:mm"));
        Console.WriteLine(date.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}
class Operations
{
    static void Main(String[] args)
    {
        Console.WriteLine("Digite um número: ");
        double numberOne = ConvertStringToNumber();

        Console.WriteLine("Digite mais um número: ");
        double numberTwo = ConvertStringToNumber();

        double sum = numberOne + numberTwo;
        double subtraction = numberOne - numberTwo;
        double multiplication = numberTwo * numberOne;
        double division = numberTwo != 0 ? numberOne / numberTwo : double.NaN;
        double average = (numberOne + numberTwo) / 2;

        Console.WriteLine($"Soma: {sum}");
        Console.WriteLine($"Subtração: {subtraction}");
        Console.WriteLine($"Multiplicação: {multiplication}");
        Console.WriteLine($"Divisão: {(numberTwo != 0 ? division : "Divisão por zero não permitida.")}");
        Console.WriteLine($"Média: {average}");
    }


    internal static double ConvertStringToNumber()
    {
        double number;

        while (true)
        {
            string enter = Console.ReadLine();

            if(double.TryParse(enter, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Valor inválido, favor inserir um número válido: ");
            }

        }

    }
}
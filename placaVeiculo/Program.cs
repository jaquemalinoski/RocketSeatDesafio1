class VehiclePlate
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a placa do veículo: ");
        string plate = Console.ReadLine();

        bool isValid = CheckPlate(plate);

        Console.WriteLine($"{(isValid ? "Verdadeiro" : "Falso")}");
    }

    static bool CheckPlate(string plate)
    {
        bool hasSevenCaracters = plate.Length == 7 ? true : false;
        bool isAlphanumeric = plate.All(char.IsLetterOrDigit);
        bool hasThreeLetters = false;
        bool hasFourNumbers = false;

        for(int i = 0; i < 3; i++)
        {
            if (char.IsLetter(plate[i]))
            {
                hasThreeLetters = true;
            } else
            {
                hasThreeLetters = false;
                break;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (char.IsDigit(plate[i]))
            {
                hasFourNumbers = true;
            }
            else
            {
                hasFourNumbers = false;
                break;
            }
        }

        return hasSevenCaracters && isAlphanumeric && hasThreeLetters && hasFourNumbers;

    }
}

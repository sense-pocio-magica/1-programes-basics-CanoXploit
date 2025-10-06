namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Diguem el primer numero: ");
        var numero1 = Console.ReadLine();
        float numeromitjana1 = Convert.ToSingle(numero1);

        Console.Write("Diguem el segon numero: ");
        var numero2 = Console.ReadLine();
        float numeromitjana2 = Convert.ToSingle(numero2);

        Console.Write("Diguem el tercer numero: ");
        var numero3 = Console.ReadLine();
        float numeromitjana3 = Convert.ToSingle(numero3);

        var mitjana = (numeromitjana1 + numeromitjana2 + numeromitjana3) / 3;
        Console.WriteLine($"La mitjana és {mitjana}!");
    }
}

namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix una paraula: ");
        var paraula = Console.ReadLine();
        var primera = paraula[0];
        var ultima = paraula[paraula.Length - 1];
        var mig = paraula[paraula.Length / 2];

        Console.WriteLine($"La primera lletra es {primera}, l'ultima es {ultima} i la del mig es {mig}");
    }
}

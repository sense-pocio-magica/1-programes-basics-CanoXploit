namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom: ");
        var nom = Console.ReadLine();
        var majusnom = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower();

        Console.Write("Introdeuxi el teu primer cognom: ");
        var cognom = Console.ReadLine();
        var majuscognom = cognom.Substring(0, 1).ToUpper() + cognom.Substring(1).ToLower();


        Console.WriteLine($"El teu nom és {majusnom} {majuscognom}");

    }
}
